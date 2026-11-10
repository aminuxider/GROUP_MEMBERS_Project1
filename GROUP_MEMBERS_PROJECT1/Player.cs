using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLuck
{
    internal class Player
    {
        public string name = "";
        public int avatar;
        public int points;
        public bool isSetUp;
        public string NameUpper()
        {
            return name.ToUpper();
        }

        public void Reset()
        {
            name = "";
            avatar = 0;
            points = 0;
            isSetUp = false;
        }
    }
}

Aminux09
aminux_yd09
 
 
 
breathing oxygen