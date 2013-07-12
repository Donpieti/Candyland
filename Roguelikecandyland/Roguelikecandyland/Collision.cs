using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roguelikecandyland
{
    public class collision
    {
        public Boolean wall(int x, int y)
        {
            if (GameManager.map.GetField(x + 1, y + 1).Text == 'o')
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }


        public Boolean door(int x, int y)
        {
            if (GameManager.map.GetField(x + 1, y + 1).Text == 'x') //Türsymbol?
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
    }
}
