using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFAScontrol
{
    public class GestureSurface
    {
        public GestureSurface() { }
        public int X_max { get; set; }
        public int Y_max { get; set; }
        public int X_min { get; set; }
        public int Y_min { get; set; }

        public int width
        {
            get
            {
                return X_max - X_min;
            }
        }
        public int height
        {
            get
            {
                return Y_max - Y_min;
            }
        }
    }
}
