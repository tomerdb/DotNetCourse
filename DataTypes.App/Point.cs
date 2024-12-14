using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telhai.cs.DotNet.TomerHarari.DataTypesApp
{
    /// <summary>
    /// Class
    /// </summary>
    public class Point
    {
        //1 --Fields (Data)
        private int _x;
        private int _y;

        //2--Properties (Data Accessors)
        /// <summary>
        /// int myx = p1.X; // get
        /// p1.X = 10; // set
        /// </summary>
        public int X
        {
            get { return _x; }
            set
            {
                if (value > 0)
                    _x = value;
                else
                {
                    _x = 0;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Y
        {
            get { return _y; }
            set
            {
                if (value > 0)
                    _y = value;
                else
                {
                    _y = 0;
                }
            }
        }


        //3--Constractors (Init Data / And Other Init Task)

        public Point():this(0)
        {
        }

        public Point(int loc):this(loc,loc)
        {
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        //4--Functions (Operations on Data / Calculations)

        private string GetInfo()
        {
            string info= $"X={_x}, Y={_y}";
            return info;
        }

        public override string ToString()
        {
            return GetInfo();
        }


    }
}
