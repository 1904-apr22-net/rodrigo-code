using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            Person person1 = new Person
            {
                ID = 1,
                Name = "Nick",
                Address = new Address
                {
                    Street = "123 Main St",
                    City = "Dallas",
                    State = "TX",
                }
            };
            Person person2= new Person
            /*{
                ID = 1,
                Name = "Fred",
                Address = new Address
                {
                    Street = "321 Main St",
                    City = "Fort Worth",
                    State = "TX",
                }
            );*/
            {
                ID = 2,
                Name = "Fred",
                Address = new Address
                {
                    Street = "321 Main St",
                    City = "Fort Worth",
                    State = "TX",
                }
            };
            persons.Add(person1);
            persons.Add(person2);
 
            // we've seen $ strings
            // @ strings are to disable escape sequences like \n
            SerializationXMLToFile(@"C:\revature\persons.xml", persons);
        }

        private static void SerializationXMLToFile(string fileName, List<Person> persons)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Person>));
            var fileStream = new FileStream(fileName, FileMode.Create);
            xmlSerializer.Serialize(fileStream, persons);
        }
                    

    }

        //private static void DeserializationXMLToFile(string fileName, List<Person> persons)
    
}
