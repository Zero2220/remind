using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Data : Iwrite,Iread
    {
        public Data() 
        {
            Seed();
        }
        private string Path = "C:\\Users\\anarpi\\Desktop\\New folder\\ConsoleApp17\\ConsoleApp17\\Data\\";
        public List<Product> Products;

        public void Seed()
        {

            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Name= "assd",
                },
                new Product(){Name ="fdsagg"},
                new Product(){Name ="afdddddd"}

            };
            var json = JsonSerializer.Serialize(products, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            using (FileStream fs = new (Path + "Products.json", FileMode.Open))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(json);
                sw.Close();
            }
            
            if (!File.Exists(Path+"Products.json"))
            {
                using (FileStream stream = new(Path + "Products.json", FileMode.Open))
                {
                    StreamWriter sw= new StreamWriter(stream);
                    sw.Write(json);
                    sw.Close();
                };
            }


        }

        public void AddProduct(Product product)
        {
            var json = JsonSerializer.Serialize(product, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
                

            
                using (FileStream stream = new(Path + "Products.json", FileMode.Open))
                {
                    StreamWriter sw = new StreamWriter(stream);
                    sw.Write(json);
                    sw.Close();
                };
            
        }

        public void AddProducts(List<Product> products)
        {

            var json =JsonSerializer.Serialize(products);
            
                using (FileStream stream = new(Path + "Products.json", FileMode.Open))
                {
                    StreamWriter sw = new StreamWriter(stream);
                    sw.Write(json);
                    sw.Close();
                };

            
            
        }

        public void RemoveById()
        {
            
        }

        public void UpdateById()
        {
            
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> Read()
        {
            string? json = null;

            using (FileStream fs =new FileStream(Path + "products.json",FileMode.Open))
            {
               StreamReader sr = new StreamReader(fs);
                json = sr.ReadToEnd();
                sr.Close();
            }
            var ProductList = JsonSerializer.Deserialize<List<Product>>(json);
            return ProductList;
        }
    }

    
}
