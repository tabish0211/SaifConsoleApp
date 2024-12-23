using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaifConsoleApp
{
    internal class Practice
    {
        //static async Task Main()
        //{
        //    var watch = new System.Diagnostics.Stopwatch();
        //    watch.Start();
        //    //M1();
        //    await M1();
        //    Console.WriteLine("I am not blocked still working...");
        //    watch.Stop();
        //    Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        //    Console.ReadLine();
        //}

        private static async Task  M1()
        {
            Console.WriteLine("M1 got called");
            //SQLDataSource sQLDataSource = await GetSQlData();
            Task<SQLDataSource> sQLDataSource = GetSQlData();
            //var resultSqlDataSource = await sQLDataSource;
           // Console.WriteLine("Record fetched from SQL Data Source");


            //MySqlDataSource mysQLDataSource = await GetMySQlData();
            Task<MySqlDataSource> mysQLDataSource = GetMySQlData();
            //var resultMySqlDataSource = await mysQLDataSource;

            //Console.WriteLine("Record fetched from My SQL Data Source");


            // OracleDataSource oraclesQLDataSource = await GetOracleData();
            Task<OracleDataSource> oraclesQLDataSource = GetOracleData();
            
          //  var resultSqlDataSource = await sQLDataSource;
           // Console.WriteLine("Record fetched from SQL Data Source");
            //var resultMySqlDataSource = await mysQLDataSource;
            //Console.WriteLine("Record fetched from My SQL Data Source");
            //var resultoraclesQLDataSource = await oraclesQLDataSource;
            //var completeAllTasks = Task.WhenAll(sQLDataSource, mysQLDataSource, oraclesQLDataSource);
            //var result = await completeAllTasks;
            //if (completeAllTasks.IsCompleted)
            //{
            //    Console.WriteLine("Record fetched from SQL Data Source");
            //    Console.WriteLine("Record fetched from My SQL Data Source");                
            //    Console.WriteLine("Record fetched from Oracle SQL Data Source");
            //}

            List<Task> tasks = new List<Task>() { sQLDataSource, mysQLDataSource, oraclesQLDataSource };
            while (tasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(tasks);
                if (finishedTask==sQLDataSource)
                {
                    Console.WriteLine("Record fetched from SQL Data Source");
                }
                else if (finishedTask==mysQLDataSource)
                {
                    Console.WriteLine("Record fetched from My SQL Data Source");
                }
                else if (finishedTask == oraclesQLDataSource)
                {
                    Console.WriteLine("Record fetched from Oracle SQL Data Source");
                }

               // await finishedTask;
                tasks.Remove(finishedTask);

            }
            

        }
        private static async Task<SQLDataSource> GetSQlData()
        {
            Console.WriteLine("Getting Data from SQL");
            await Task.Delay(12000);
            Console.WriteLine("Sql Data is finished");
            return new SQLDataSource();
        }

        private static async Task<MySqlDataSource> GetMySQlData()
        {

            Console.WriteLine("Getting Data from MY SQL");
            await Task.Delay(10000);

            Console.WriteLine("MY Sql Data is finished");
            return new MySqlDataSource();
        }


        private static async Task<OracleDataSource> GetOracleData()
        {

            Console.WriteLine("Getting Data from Oracle SQL");
            await Task.Delay(14000);

            Console.WriteLine("Oracle Sql Data is finished");
            return new OracleDataSource();
        }


    }

    class SQLDataSource
    { 
    }

    class OracleDataSource
    {
    }

    class MySqlDataSource
    {
    }
}
