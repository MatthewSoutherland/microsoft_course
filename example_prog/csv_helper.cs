using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "data.csv"; // Replace with the path to your CSV file

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",",
            HasHeaderRecord = true
        };

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, config))
        {
            var records = new List<Person>();
            csv.Read();
            csv.ReadHeader();
            while (csv.Read())
            {
                var record = new Person
                {
                    Id = csv.GetField<int>("Id"),
                    Name = csv.GetField<string>("Name"),
                    Age = csv.GetField<int>("Age")
                };
                records.Add(record);
            }

            foreach (var person in records)
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
