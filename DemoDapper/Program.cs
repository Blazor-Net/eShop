using Dapper;
using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DemoDapper
{
   public class Program
    {
        public static string cString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=aspnet-eShop.Web-0B3AD676-46B4-4F09-9DB8-180E626C990C;Integrated Security=True";
        public static IEnumerable<Product> Products;
        static void Main(string[] args)
        {
            var da = new DataAccessLayer(cString);
            var allProducts = da.Query<Product , dynamic>("SELECT * from Product", new { });
            var productByName = da.Query<Product, dynamic>("Select * from Product where Name =@Name",new{Name="Product Name"});    
            
            //UpdateProduct();
            //var products = GetProducts();
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.Id}-{ product.Name}-{product.Brand}-{product.Price}");
            //}
            Console.ReadLine();
        }

        static IEnumerable<Product> GetProducts() 
        {
            using (IDbConnection conn = new SqlConnection(cString))
            {                
               Products = conn.Query<Product>("Select * from Product");
            }
            return Products;
        }
        static void InsertProduct() 
        {
            var sql = @"INSERT INTO Product (ProductId,Brand,Name,Price) VALUES (@ProductId, @Brand, @Name,@Price)";
            using (IDbConnection conn = new SqlConnection(cString))
            {
                conn.Execute(sql, new { ProductId = 1000002, Brand = "Brand", Name = "Product Name", Price = 10 });
            }
        }
        static void UpdateProduct() 
        {
            var sql = @"UPDATE Product SET ImageLink = @Url WHERE Name = @Name";
            using (IDbConnection conn = new SqlConnection(cString))
            {
                conn.Execute(sql, new { Url ="https://www.whatever.com" , Name ="Product Name"});
            }
        }
    }
}
