using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hil.Services.Implementations
{
    public class Room
    {
        static int _id=0;
        public  int Id {get;set;}
        public int No { get;set;}
        public int Price { get;set;}
        public bool IsReserved { get; set;}
        public Room()
        {
            _id++;
            Id= _id;        
        }

    }
}
