using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Risiko
{
    public class Player
    {
        int number=0;
        int id;
        int region = 0;
        String name="None";
        Form1 main_form = new Form1();
        public Player(int n,  int i,Form1 f)
        {
            number = n;
            id = i;
            main_form = f;
        }

        public int getID()
        {
            return id;
        }

        public Boolean decreaseNum(int n,int _id)
        {
            if (number -n > -1)
            {
                number = number - n;
                if (_id == 0)
                {
                    main_form.label_tank1.Text = number.ToString();
                }
                if (_id == 1)
                {
                    main_form.label_tank2.Text = number.ToString();
                }
                if (_id == 2)
                {
                    main_form.label_tank3.Text = number.ToString();
                }
                if (_id == 3)
                {
                    main_form.label_tank4.Text = number.ToString();
                }
                return true;
            }
            else return false;
        }

        public int getNum()
        {
            return number;
        }
        
        public String getName()
        {
            return name;
        }

        public void increaseNum(int n,int _id)
        {
            number += n;
            if (_id == 0)
            {
                main_form.label_tank1.Text = number.ToString();
            }
            if (_id == 1)
            {
                main_form.label_tank2.Text = number.ToString();
            }
            if (_id == 2)
            {
                main_form.label_tank3.Text = number.ToString();
            }
            if (_id == 3)
            {
                main_form.label_tank4.Text = number.ToString();
            }
        }

        public void setNumRegion(int n)
        {
            region = n;
        }

        public Boolean decreaseNumRegion()
        {
            if (region > 0)
            {
                region -= 1;
                return true;
            }
            else
                return false;
        }

        public void addNumRegion()
        {
             region++;
        }

        public int getRegion()
        {
            return region;
        }

        public void clearPlayer()
        {
            region = 0;
            number = 0;
            id = 0;
        }
    }
}
