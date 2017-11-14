using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenOOPConcepts
{
    /// <summary>
    /// Interface IFlyable for animals that can fly.
    /// Will be used to show two examples on incorrect polymorphism usage.
    /// </summary>
    interface IFlyable
    {
        void CanFly();
        void HasWings();
    }
}
