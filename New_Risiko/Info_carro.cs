using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Risiko
{
    class Info_carro
    {
        private String name;
        public Info_carro(String n)
        {
            name = n;
        }
        public Info_carro()
        {
            
        }

        public void setName(String n)
        {
            name = n;
        }

        public String getName()
        {
            return name;
        }
    }
}
