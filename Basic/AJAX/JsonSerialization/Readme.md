##### Demonstrates how to use the DataContractJsonSerializer to serialize and deserialize data in the JavaScript Object Notation (JSON) format.
---------
 - This serialization engine converts JSON data into instances of .NET Framework types and back into JSON data.
 -  DataContractJsonSerializer supports the same types as DataContractSerializer. 
 -  AJAX support in Windows Communication Foundation (WCF) is optimized for use with ASP.NET AJAX through the ScriptManager control. 
 
##### Output
![img](https://raw.githubusercontent.com/niisar/WCF/master/Basic/AJAX/JsonSerialization/JsonSerialization.JPG)

 
##### Sample Code
``` cs
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Nisar";
            p.age = 23;

            MemoryStream stream1 = new MemoryStream();

            //Serialize the Person object to a memory stream using DataContractJsonSerializer.
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
            ser.WriteObject(stream1, p);

            //Show the JSON output.
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            Console.Write("JSON form of Person object: ");
            Console.WriteLine(sr.ReadToEnd());

            //Deserialize the JSON back into a new Person object.
            stream1.Position = 0;
            Person p2 = (Person)ser.ReadObject(stream1);

            //Show the results.
            Console.Write("Deserialized back, got name=");
            Console.Write(p2.name);
            Console.Write(", age=");
            Console.WriteLine(p2.age);

            Console.WriteLine("Press <ENTER> to terminate the program");
            Console.ReadLine();
        }
```

> **[Ref.](https://msdn.microsoft.com/en-us/library/bb410770(v=vs.110).aspx)**

