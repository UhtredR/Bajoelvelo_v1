using Bajoelvelo_v1.Infraestructura;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bajoelvelo_v1.Clases_Func
{

    public class DetalleFactura
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class Factura
    {
        private SqlConnection cnx;


        public int IdFactura { get; private set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public int IdNegocio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; private set; }
        public decimal Itbis { get; private set; }
        public List<DetalleFactura> DetallesFacturas { get; private set; }


        public Factura( int idUsuario, int idNegocio)
        {
            IdUsuario = idUsuario;
            IdNegocio = idNegocio;
            Fecha = DateTime.Now;
            DetallesFacturas = new List<DetalleFactura>();
            cnx = Conexion.Conectar();

        }

        public bool AgregarProducto(int idProducto, string nombreProducto, int cantidad, decimal precioUnitario, int stockDisponible)
        {
            if (cantidad > stockDisponible)
            {
                return false;
            }
        
            decimal subtotalItem = cantidad * precioUnitario;

            DetalleFactura detalle = new DetalleFactura
            {
                IdProducto = idProducto,
                NombreProducto = nombreProducto,
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario,
                Subtotal = subtotalItem
            };
            
            DetallesFacturas.Add(detalle);

            CalcularTotales();


            return true;

        }

        public void CalcularTotales()
        {
            Subtotal = 0;

           
            foreach (var detalle in DetallesFacturas)
            {
                Subtotal += detalle.Subtotal;
            }

            
            Itbis = Subtotal * 0.18m;
           
            Total = Subtotal + Itbis;
        }

        public DataTable ObtenerClientes()
        {
            DataTable dt = new DataTable();

            try
            {
                cnx.Open();
                string query = "SELECT ID_Cliente, Nombre + ' ' + Apellido AS NombreCompleto FROM Cliente";
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes"+ ex.Message);
            }
            finally
            {
                cnx.Close();
            }

            return dt;
        }

        public DataTable ObtenerProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                string query = "SELECT ID_Producto, Nombre, Precio_unitario, Stock FROM Producto WHERE Disponible = 1";
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos" + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
            return dt;
        }

        public int GuardarFactura()
        {
            if (DetallesFacturas.Count == 0)
            { 
                throw new Exception("Debe agregar al menos un producto");
            }

            if (IdCliente <= 0)
            {
                throw new Exception("Debe seleccionar un cliente");
            }

            try
            {
                cnx.Open();

                SqlTransaction transaction = cnx.BeginTransaction();

                try
                {
                    string insertarFactura = @"INSERT INTO Factura (Fecha_factura, ID_Usuario, ID_Cliente, ID_Negocio) 
                                         VALUES (@fecha, @idUsuario, @idCliente, @idNegocio); 
                                         SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdFactura = new SqlCommand(insertarFactura, cnx, transaction);
                    cmdFactura.Parameters.AddWithValue("@fecha", Fecha);
                    cmdFactura.Parameters.AddWithValue("@idUsuario", IdUsuario);
                    cmdFactura.Parameters.AddWithValue("@idCliente", IdCliente);
                    cmdFactura.Parameters.AddWithValue("@idNegocio", IdNegocio);

                    IdFactura = Convert.ToInt32(cmdFactura.ExecuteScalar());

                    foreach (var detalle in DetallesFacturas)
                    {
                        string insertarDetalle = @"INSERT INTO Detalle_Factura (ID_Factura, ID_Producto, Cantidad, Subtotal)
                                            VALUES (@idFactura, @idProducto, @cantidad, @subtotal)";

                        SqlCommand cmdDetalle = new SqlCommand(insertarDetalle, cnx, transaction);
                        cmdDetalle.Parameters.AddWithValue("@idFactura", IdFactura);
                        cmdDetalle.Parameters.AddWithValue("@idProducto", detalle.IdProducto);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", detalle.Subtotal);
                        cmdDetalle.ExecuteNonQuery();


                        string actualizarStock = @"UPDATE Producto SET Stock = Stock - @cantidad  WHERE ID_Producto = @idProducto";

                        SqlCommand cmdStock = new SqlCommand(actualizarStock, cnx, transaction);
                        cmdStock.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        cmdStock.Parameters.AddWithValue("@idProducto", detalle.IdProducto);
                        cmdStock.ExecuteNonQuery();

                    }
                    transaction.Commit();
                    return IdFactura;

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al guardar la factura" + ex.Message);
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error de conexión: " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }

        }


        


    }
}
