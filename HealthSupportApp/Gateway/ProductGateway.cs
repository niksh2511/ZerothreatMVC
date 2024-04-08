using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using HealthSupportApp.Models;
using HealthSupportApp.Models.DoctorModel;
using HealthSupportApp.Models.HomeModel;
using HealthSupportApp.Models.MedicalModel;
using HealthSupportApp.Models.ProductModel;
using HealthSupportApp.Models.UserModel;

namespace HealthSupportApp.Gateway
{
    public class ProductGateway : ParentGateway
    {
        public List<Product> GetProducts()
        {
            Query = "SELECT * FROM Product";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (Reader.Read())
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt16(Reader["ProductId"]);
                product.ProductName = Reader["ProductName"].ToString();
                product.ProductDescription = Reader["ProductDescription"].ToString();
                product.ProductCategory = Reader["ProductCategory"].ToString();
                products.Add(product);
            }
            Reader.Close();
            Connection.Close();
            return products;
        }

        public List<Product> Serach(string search)
        {
            Query = "SELECT * FROM Product WHERE ProductName LIKE '%" + search + "%' OR ProductDescription LIKE '%" + search + "%' OR ProductCategory LIKE '%"+ search + "%'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (Reader.Read())
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt16(Reader["ProductId"]);
                product.ProductName = Reader["ProductName"].ToString();
                product.ProductDescription = Reader["ProductDescription"].ToString();
                product.ProductCategory = Reader["ProductCategory"].ToString();
                products.Add(product);
            }
            Reader.Close();
            Connection.Close();
            return products;

        }

        public int AddProduct(Product product)
        {
            if(product.ProductId == 0)
            {
                Query = "INSERT INTO Product VALUES('" + product.ProductName + "', '" + product.ProductDescription + "', '" + product.ProductCategory + "')";
            }
            else
            {
                Query = "UPDATE Product SET ProductName= '" 
                    + product.ProductName + "', ProductDescription = '" 
                    + product.ProductDescription + "', ProductCategory = '" 
                    + product.ProductCategory + "' WHERE ProductId = " + product.ProductId;
            }
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Product GetProduct(int id) 
        {
            Query = "SELECT * FROM Product WHERE ProductId = " + id;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Product product = new Product();
            if( Reader.Read() )
            {
                product.ProductId = Convert.ToInt16(Reader["ProductId"]);
                product.ProductName = Reader["ProductName"].ToString();
                product.ProductDescription = Reader["ProductDescription"].ToString();
                product.ProductCategory = Reader["ProductCategory"].ToString();
            }
            
            Reader.Close();
            Connection.Close();

            return product;
        }

        public bool DeleteProduct(int id)
        {
            Query = "DELETE FROM Product WHERE ProductId = " + id;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader(); 
            Reader.Close();
            Connection.Close();
            return true;
        }
    }
}