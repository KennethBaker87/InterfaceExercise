using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public int Wipers { get; set; }
        public int HeadLights { get; set; }

    }
}
