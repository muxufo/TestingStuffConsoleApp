using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace TestingCodeConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var str = System.IO.File.ReadAllText(@"C:\Users\Nicolas\source\repos\TestingCodeConsoleApp\TestingCodeConsoleApp\calls.json");

            var callsObj = JsonConvert.DeserializeObject<List<calls>>(str);

            var list = callsObj.Select(
                x => new GetContestPotentialWinnersQueryResult{Id = x.id, DataLocationTableName = Vote_Data_Type.ivr}
            ).ToList();

            var selectItem = JsonConvert.SerializeObject(list);
            
            System.IO.File.WriteAllText(@"C:\Users\Nicolas\source\repos\TestingCodeConsoleApp\TestingCodeConsoleApp\test.txt",selectItem);
        
            
            
            
            Console.ReadKey();
        }

    }
}