using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;



namespace Project1
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            //Read();
            const string fileName = "bishkek_er.csv";

            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(fileName).ToList();
            foreach(var line in lines)
            {
                string[] parts = line.Split(',');

                Person newPerson = new Person();

                newPerson.Name = "@"+parts[0] + " " + parts[1];
                newPerson.Phone =parts[2];
                people.Add(newPerson);
			
				// nn
				//part[2]
				

            }

            foreach(var person in people)
            {
                Console.WriteLine($"{person.Name},{person.Phone}");
            }

            Console.ReadLine();
        }
       
        
           
        }

        

    }

    
