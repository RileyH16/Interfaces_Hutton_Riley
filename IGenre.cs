using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Hutton_Riley
{
    interface IGenre
    {
        //Automatic propery for Esrb
        public string Esrb { get; set; }
        
        //Automatic property for Genre
        public string Genre { get; set; }

        //Automatic prpoerty for Title
        public string Title { get; set; }

        //Decribe method to return a string
        public string Describe();

    }
}
