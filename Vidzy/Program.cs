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
            
            vidzyContext.AddVideo("The Lion King", new DateTime(1994, 5, 1), "Family");

        }
    }
}
