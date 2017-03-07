using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Risiko
{
    class Game
    {
        private int number;
        private int tank_number;
        private List<String> names;
        public Game()
        {
            names = new List<string>();
        }

        public void setNumber(int n)
        {
            number = n;
        }

        public Boolean getNumber()
        {
            return (names.Count()==number);
        }

        public void setTankNumber(int n)
        {
            tank_number = n;
        }

        public int getTankNumber()
        {
            return tank_number;
        }

        public int getPlayerNum()
        {
            return number;
        }
        public Boolean setName(String c)
        {
            if (!names.Contains(c))
            {
                names.Add(c);
                return true;
            }
            else
                return false;
        }

        public void clearList()
        {
            names.Clear();
            tank_number = 0;
            number = 0;
        }
       
    }
}
