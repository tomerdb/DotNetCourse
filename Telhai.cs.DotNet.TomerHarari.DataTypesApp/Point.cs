namespace Telhai.cs.DotNet.TomerHarari.DataTypesApp
{
    /// <summary>
    /// Represents a point with X and Y coordinates, with range constraints between 0 and 100.
    /// </summary>
    public class Point
    {
        // 1 -- Fields (Data)
        private int _x;
        private int _y;

        // 2 -- Properties (Data Accessors)

        /// <summary>
        /// Gets or sets the X-coordinate of the point. 
        /// Values greater than 100 are capped at 100, and negative values are set to 0.
        /// </summary>
        public int X
        {
            get { return _x; }
            set
            {
                if (value > 100)
                    _x = 100;
                else if (value > 0)
                {
                    _x = value;
                }
                else
                {
                    _x = 0;
                }
            }
        }

        /// <summary>
        /// Gets or sets the Y-coordinate of the point. 
        /// Values greater than 100 are capped at 100, and negative values are set to 0.
        /// </summary>
        public int Y
        {
            get { return _y; }
            set
            {
                if (value > 100)
                    _y = 100;
                else if (value > 0)
                {
                    _y = value;
                }
                else
                {
                    _y = 0;
                }
            }
        }

        // 3 -- Constructors (Init Data / And Other Init Task)

        /// <summary>
        /// Initializes a new instance of the Point class with default values (0, 0).
        /// </summary>
        public Point() : this(0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class with the same value for both X and Y coordinates.
        /// </summary>
        /// <param name="loc">The value for both X and Y coordinates.</param>
        public Point(int loc) : this(loc, loc)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class by copying the values from another Point object.
        /// </summary>
        /// <param name="point">The Point object to copy.</param>
        public Point(Point point) : this(point.X, point.Y)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class with specific values for X and Y coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate value.</param>
        /// <param name="y">The Y-coordinate value.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // 4 -- Functions (Operations on Data / Calculations)

        /// <summary>
        /// Gets a string representation of the point's coordinates.
        /// </summary>
        /// <returns>A string in the format "X={value}, Y={value}".</returns>
        private string GetInfo()
        {
            string info = $"X={_x}, Y={_y}";
            return info;
        }

        /// <summary>
        /// Returns a string representation of the Point object.
        /// </summary>
        /// <returns>A string describing the point's coordinates.</returns>
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
