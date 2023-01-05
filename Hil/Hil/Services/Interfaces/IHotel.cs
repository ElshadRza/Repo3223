using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hil.Services.Interfaces
{
    internal interface IHotel
    {
        public void Menu();
        public void Create();
        public void GetAll();
        public void Delete();
        public void Reserve();
        public void Finish();

    }
}
