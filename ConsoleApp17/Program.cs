using ConsoleApp17;

string opr;
Data data = new Data();
do
{
    Console.Beep();
    Console.WriteLine("====================================Menu===================================== ");
    Console.WriteLine("1.AddProduct");
    Console.WriteLine("2.RemoveProducts");
    Console.WriteLine("3.show all");
    Console.WriteLine("4.Remove");
    Console.WriteLine("0.Exit");
    opr =Console.ReadLine();
    switch (opr)
    {
        case "1":
            Console.Beep();
            Console.Clear();
            Console.WriteLine("Productin adini daxil edin ");
            string name = Console.ReadLine();
            string dateStr;
            DateTime date1;

            if (name != null )
            {
                Console.WriteLine("Productin DateTimesini  daxil edin ");
                dateStr = Console.ReadLine();


                if (dateStr != null && DateTime.TryParse(dateStr, out date1))
                {

                    Product product1 = new Product() { Name =name ,ExpireDate =date1};

                    data.AddProduct(product1);
                }
                   
                
            }
            

            break;
        case "2":
            
           
            break; 
        case "3":
            List<Product> products = data.Read();

            foreach (var item in products)
            {
                Console.WriteLine("Name" +item.Name +"date:" +item.ExpireDate);
            }
            break;
    }
}
while(opr != "0");