using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidzyContext = new VidzyDbContext();
            
            vidzyContext.AddVideo("Half Baked", new DateTime(1998, 1, 1), "Comedy", (byte)Classification.Gold);

        }
    }
}
