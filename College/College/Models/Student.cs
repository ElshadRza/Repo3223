using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace College.Models
{
    public class Student:StudentCervice
    {
        
        
        private static string _name { get; set; }
        private static string _surname { get; set; }
        private int _average { get; set; }
        public static int Id { get; set; }
        public  string Name { get=>_name; set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    Console.WriteLine("Name can contain 3 digits minimum and 15 digits maximum.");
                }
                else
                {
                    value = _name;
                }
                ;
            } }
        public string Surname { get=>_surname; set
            {
                if(value.Length<3||value.Length>15)
                {
                    Console.WriteLine("Surname can contain 3 digits minimum and 15 digits maximum.");
                }
                else
                {
                    value = _surname;
                }
            } }
        public int Average { get => _average; set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Average point can be between 0 and 100 only.");
                }
                else
                {
                    value = _average;
                }
            } }
        
        public Student() 
        {
            Menu();
            while (Input != 0)
            {
                Create(Name, Surname);

                Delete(Id);
                Edit(Id,Name,Surname);
            }
            
        }

    }
}
