using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DummyDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string schemesPath = string.Concat(projectPath, @"\JSONScheme\TestScheme\");
            string dataPath = string.Concat(projectPath, @"\TestData\");

            string schemePath1 = string.Concat(schemesPath, "Clients-scheme.json");
            string schemePath2 = string.Concat(schemesPath, "Products-scheme.json");

            string dataPath1 = string.Concat(dataPath, "Clients-data.csv");
            string dataPath2 = string.Concat(dataPath, "Products-data.csv");

            TableScheme tableScheme1 = JsonConvert.DeserializeObject<TableScheme>(File.ReadAllText(schemePath1));
            TableScheme tableScheme2 = JsonConvert.DeserializeObject<TableScheme>(File.ReadAllText(schemePath2));

            Table table1 = new Table(new List<Row>(), tableScheme1);
            Table table2 = new Table(new List<Row>(), tableScheme2);

            string[] rows1 = GetRowsFromCSV(dataPath1);
            for (int i = 1; i < rows1.Length; i++)
            {
                
            }
        }

        static string[] GetRowsFromCSV(string dataPath)
        {
            return File.ReadAllText(dataPath).Split("\n");
        }
    }
}