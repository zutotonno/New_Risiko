using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Risiko
{
    class Stack
    {
        private Boolean number = false;
        private Boolean color = false;
        


        public void setNumber(Boolean t)
        {
            number = t;
        }
        public Boolean getNumber()
        {
            return number;
        }

        public void setColor(Boolean t)
        {
            color = t;
        }
        public Boolean getColor()
        {
            return color;
        }
    }
}
