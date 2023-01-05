using Hil.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hil.Services.Implementations
{
    internal class Hotel:IHotel
    {
        public int Id1 { get; set; }
        public string Name { get; set; }
        public Room[] Rooms = { };
        public string input { get; set; }
        public bool status { get; set; } = true;
        public Hotel()
        {
            
            while (status == true) { 
            Menu();
            Create();
            GetAll();
            Delete();
            Reserve();
            Finish();
            }
        }

        public void Create()
        {
            
            while (input == "1") {
                Console.Clear();
                Console.WriteLine("Write the room number:");
            int no=int.Parse(Console.ReadLine());
            Console.WriteLine("Add the price:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("If the room is reserved press 1 if the room is not press 2:");
            string reserve=Console.ReadLine();
            

            Room room = new Room()
            {
             No=no,
             Price =price  
            };
                if (reserve == "1")
                {
                    room.IsReserved = true;
                }
                else if(reserve == "2") 
                {
                    room.IsReserved = false;
                }
                Array.Resize(ref Rooms,Rooms.Length+1);
            Rooms[Rooms.Length-1] = room;
                
                Menu();
            }
        }

        public void GetAll()
        {
            
            while(input == "2")
            
                {
                Console.Clear();
                for (int i=0; i<Rooms.Length;i++)
                {
                    Console.WriteLine("The room's number is: {0}. ",Rooms[i].No);
                    Console.WriteLine("Price is: {0} dollars. ",Rooms[i].Price);
                    Console.WriteLine("ID is {0}. ", Rooms[i].Id);
                    if(Rooms[i].IsReserved==true)
                    {
                        
                        Console.WriteLine("This room is reserved.\n");
                    }
                    else
                    {
                        
                        Console.WriteLine("This room is not reserved.\n");
                    }
                }
                
                Menu();
                }
        }

        public void Delete()
        {
            while(input == "3")
            {
                Console.Clear();
                Console.WriteLine("Enter the room's ID you want to delete.");
                int id = int.Parse(Console.ReadLine());
                for (int i=0; i<=id;i++)
                {
                    if (Rooms[i].Id==id)
                    {
                        Rooms[i] = Rooms[Rooms.Length-1];
                        Array.Resize(ref Rooms, Rooms.Length - 1);
                        Console.WriteLine("The room is deleted.");
                        break;
                    }
                    else if (Rooms[i].Id != id)
                    {
                        Console.WriteLine("We dont have a room with this ID.Please write an existing ID:");
                        id=int.Parse(Console.ReadLine());
                        break;
                    }
                }
                Menu();
            }
        }

        public void Reserve()
        {
            while (input == "4") { 
            Console.Clear();
            Console.WriteLine("Please write the room's ID you want to reserve:");
            int id = int.Parse(Console.ReadLine());
            for (int i=0;i<Rooms.Length;i++)
            {
                if (Rooms[i].Id == id && Rooms[i].IsReserved==false)
                {
                    Rooms[i].IsReserved = true;
                    Console.WriteLine("You Reserved the room with this ID: {0} ", Rooms[i].Id);
                }
                else if (Rooms[i].Id == id && Rooms[i].IsReserved == true)
                {
                    Console.WriteLine("This room is already reserved.Please type another Room ID:");
                    id = int.Parse(Console.ReadLine());

                }
                else if (Rooms[i].Id != id)
                {
                    Console.WriteLine("We dont have a room with this ID.Please type in another ID:");
                    id = int.Parse(Console.ReadLine());
                }
            }
                Menu();
            }
        }

        public void Menu()
        {
            Console.WriteLine("1.Add a new room.");
            Console.WriteLine("2.Show all rooms.");
            Console.WriteLine("3.Delete a room.");
            Console.WriteLine("4.Reserve a room.");
            Console.WriteLine("5.Finish.");
            input =Console.ReadLine();
            
        }

        public void Finish()
        {
            if (input == "5")
            {
                Console.WriteLine("You ended the process.");
                status = false;
                return;

            }
        }
    }
}
