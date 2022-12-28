using College.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Models
{
    public class StudentCervice : Group, StudentService1
    {
        public int Input { get; set; }
        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Welcome.Please write the number in front of the process you want:");
            Console.WriteLine("1.Add Student.");
            Console.WriteLine("2.Delete a Student.");
            Console.WriteLine("3.Change information about a Student.");
            Console.WriteLine("4.See All the Students informations in a group.");
            Console.WriteLine("5.See if a Student exists with the ID you type in.");
            Console.WriteLine("0.End the Session.");
            this.Input = int.Parse(Console.ReadLine());
        }



        public void Create(string name, string surname)
        {

            while (this.Input == 1)
            {

                Console.Clear();
                Array.Resize(ref Students, Students.Length + 3);
                Console.WriteLine("Write your Name:");
                name = Console.ReadLine();
                Console.WriteLine("Write your Surname:");
                surname = Console.ReadLine();

                Student.Id++;

                Students[Students.Length - 3] = name;
                Students[Students.Length - 2] = surname;
                Students[Students.Length - 1] = Student.Id.ToString();




                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successful");
                Console.WriteLine("Your ID is:{0}", Student.Id);
                Menu();


            }

        }

        public void Delete(int id)
        {
            while (this.Input == 2)
            {
                Console.Clear();
                Console.WriteLine("Please type in The student's ID you want to delete:");
                Student.Id = int.Parse(Console.ReadLine());


                for (int i = 2; i < Students.Length; i = i + 3)
                {
                    if (Students[i] == Student.Id.ToString())
                    {
                        Students[i - 1] = null;
                        Students[i - 2] = null;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Deleted the Student with that ID. ");
                        break;
                    }
                    else if (Student.Id < 0)
                    {
                        Console.WriteLine("We dont have a student with that id.");
                        break;
                    }
                }
                Menu();

            }

        }

        public void Edit(int id, string name, string surname)
        {
            while (Input == 3)
            {

                Console.Clear();
                Console.WriteLine("Please write the ID you want to change below:");
                Student.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Please write the name you want to change below:");
                name= Console.ReadLine();
                Console.WriteLine("Please write the Surname you want to change below:");
                surname= Console.ReadLine();
                for (int i = 2; i < Students.Length; i = i + 3)
                {
                    if (Students[i] == Student.Id.ToString())
                    {
                        Console.WriteLine("Write a number below to change your ID:");
                        Student.Id = int.Parse(Console.ReadLine());
                        Students[i] = Student.Id.ToString();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You Changed the Student with that ID. ");


                    }
                    else if (Student.Id < 0)
                    {
                        Console.WriteLine("We dont have a Student with that ID.");
                        break;
                    }

                }

                    for (int n = 0;  n < Students.Length; n++)
                    {
                    if (Students[n]==name)
                    {
                        Console.WriteLine("Please write the new name:");
                        name= Console.ReadLine();
                        Students[n] = name;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You Changed the name.");

                    }
                    }
                    for(int s=1;s < Students.Length;s++)
                {
                    if(Students[s] == surname) { 
                    Console.WriteLine("Please write the new surname:");
                    surname = Console.ReadLine();
                    Students[s] = surname;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You Changed the name.");
                    }
                }
                Menu();
            }

            

        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

