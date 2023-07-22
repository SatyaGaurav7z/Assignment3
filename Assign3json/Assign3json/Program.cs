using Assign3json;
using Assign3json.Models;

jsonSerilizationDeserilization sd =  new jsonSerilizationDeserilization();
sd.serialize_deserialize();

    Console.WriteLine("\n===================Read Data From URL=================== \n ");
ReadURL read = new ReadURL();
read.Read(); 
read.print_name();
read.print_email();
read.print_city();
read.createfile();  