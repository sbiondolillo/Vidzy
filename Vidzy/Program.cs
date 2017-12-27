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
            
            vidzyContext.AddVideo("Aladdin", new DateTime(1992, 5, 1), "Family");

        }
    }
}
