using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lõputöö___Raigo_Robin_Anni__TITge22
{
    internal class CarList
    {
        public static readonly List<Cars> cars = new List<Cars>()
        {
            new Cars()
            {
                Id = 1,
                Name = "Honda",
                Year = 2000,
                Age = 23


            },
             new Cars()
             {
                 Id = 2,
                 Name = "Subaru",
                 Year = 2002,
                 Age = 11
             },

             new Cars()
             {
                 Id = 3,
                 Name = "Toyota",
                 Year = 2006,
                 Age = 17
             },

             new Cars()
             {
                 Id = 4,
                 Name = "Mazda",
                 Year = 2010,
                 Age = 13
             },
             new Cars()
             {
                 Id = 5,
                 Name = "Lexus",
                 Year = 2022,
                 Age = 1
             }
        


        


    };
}
}
