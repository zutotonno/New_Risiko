using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Risiko
{
    [Serializable]
    class Nation
    {
        Point[] edges;
        int id;
        List<int> near = new List<int>();
        Color bg = Color.Blue;

        public Nation(Point[] edges, int id, List<int> near, Color bg)
        {
            this.edges = edges;
            this.id = id;
            this.near = near;
            this.bg = bg;
        }

        public List<int> getNear()
        {
            return this.near;
        }

        public Point[] getEdges()
        {
            return this.edges;
        }

        public int getId()
        {
            return this.id;
        }
        public Color getColor()
        {
            return this.bg;
        }
    }
}
