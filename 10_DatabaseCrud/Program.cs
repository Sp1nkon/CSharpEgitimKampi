
using System;
using System.Data;
using System.Data.SqlClient;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Menü Sipariş İşlem Paneli ******");
            Console.WriteLine();

            Console.WriteLine("------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection(
            //    "Data Source=SPINKON;Initial Catalog=EgitimKampi;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand(
            //    "INSERT INTO TbCategory (CategoryName) VALUES (@p1)", connection);

            //command.Parameters.AddWithValue("@p1", categoryName);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data source=SPINKON;initial catalog=EgitimKampi;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert into TbProduct (ProductName,ProductPrice,ProductStatus)values(@productName,@productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı!");



            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data source=SPINKON;initial catalog=EgitimKampi;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * from TbProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID: ");
            //int productID=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=SPINKON;initial catalog=EgitimKampi;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TbProduct Where ProductID=@productID",connection);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı!");


            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID: ");
            //int productID = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=SPINKON;initial catalog=EgitimKampi;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TbProduct Set ProductName=@productName,ProductPrice=@productPrice where productID=@productID", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productID",productID);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı!");

            #endregion




            Console.ReadKey();
        }
    }
}
