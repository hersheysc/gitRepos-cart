using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpoorthiShoppingCart.BO;
using System.Data.SqlClient;
using SpoorthiShoppingCart.DAL.Interfaces;

namespace SpoorthiShoppingCart.DAL
{
    public class ProductDAL:IProductDAL
    {
        public List<Product> GetAllProducts()
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            Product product;
            List<Product> products = new List<Product>();
            connetionString = @"Data Source=TRAINING\PROGET;Initial Catalog=Northwind;Integrated Security=True";
            sql = "Select ProductID,ProductName,UnitPrice,Discontinued,UnitsInstock from products";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    product = new Product();
                    product.ProductID = Convert.ToInt32(dataReader["ProductID"]);
                    product.ProductName = Convert.ToString(dataReader["ProductName"]);
                    product.UnitPrice = Convert.ToDouble(dataReader["UnitPrice"]);
                    product.Discontinued = Convert.ToInt16(dataReader["Discontinued"]);
                    product.UnitsInstock = Convert.ToInt16(dataReader["UnitsInstock"]);
                    products.Add(product);
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                
            }
            return products;
        }
    }
}

