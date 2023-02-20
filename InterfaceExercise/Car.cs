using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public int TrunkSpace { get; set; }
        public bool Convertible { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public int Wipers { get; set; }
        public int HeadLights { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
