using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
           

            //MySqlConnection connection = new MySqlConnection
            //{
            //    //Строка подключения, у вас может отличаться.
            //    ConnectionString = "server=127.0.0.1;user id=root;password=root;persistsecurityinfo=True;port=3306;database=postal_office;CharSet=utf8"
            //};

            //MySqlCommand command = new MySqlCommand("SELECT * FROM postal_office.worker;", connection);


            //connection.Open();
            //using (MySqlDataReader reader = command.ExecuteReader())
            //{
            //    System.Console.WriteLine("Идентификатор\t\tНаименование\t\tДата изменения");
            //    //Перебираем все полученные данные в цикле.
            //    while (reader.Read())
            //    {
            //        string row = $"{reader["idcat"]}\t\t{reader["name"]}\t\t{reader["dt"]}";
            //        System.Console.WriteLine(row);
            //    }
            //}

            //connection.Close();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
