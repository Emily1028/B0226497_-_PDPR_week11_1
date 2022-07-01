using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week11_1
{
    class BOX
    {
        private static int totalBOX=0;
        private double  width, height, length;
        public int id { get; set; }
        public BOX(int ID,double WIDTH, double HEIGHT, double LENGTH)
        {
            id = ID += totalBOX + 1;
            width = WIDTH;
            height = HEIGHT;
            length = LENGTH;
        }
        public double VOLUME()
        {
          return width * height * length;
        }
        public double AREA()
        {
            return width * length * 6;
        }
        
        public string showME()
        {
            return $"編號:{id}，寬:{width}，高:{height}，長:{length}，體積:{VOLUME()}，面積:{AREA()}";
        }
    }
}

