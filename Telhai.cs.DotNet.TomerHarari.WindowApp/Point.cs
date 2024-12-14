namespace Telhai.cs.DotNet.TomerHarari.WindowApp;

    public enum ShapeType: int
    {
        None=0,
        Point = 1
    };

    /// <summary>
    /// - cant create instance of it
    /// - No Implementation In abstract method
    /// - at least one abstract class must defined as abstract 
    /// </summary>
    public abstract class BaseObject
    {
        //Inherit Class must Implement
        public abstract string GetId();

        public ShapeType ShapeOfType { get; set;}


        protected BaseObject()
        {
          
             ShapeOfType = ShapeType.None;
           
            if (this.GetType() == typeof(Point))
                ShapeOfType = ShapeType.Point;

        }

        public void DisplayType()
        {
            
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class BaseShape : BaseObject
    {
        public string Id { get; private set; }
        public string Name { get;  protected set; }

        public override string GetId()
        {
            return Id;
        }


        public BaseShape()
        {
            //Set
            Id = Guid.NewGuid().ToString();
            //Get
            Name = Id;
        }

        public BaseShape(string name):this()
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Id={Id},Name={Name}";
        }

    }


    /// <summary>
    /// Class
    /// </summary>
    public class Point : BaseShape
    {


        //1 --Fields (Data)
        private int _x;
        private int _y;

        /// <summary>
        /// var id = p1.Id;
        /// p1.Id = "123-AA";
        /// </summary>
       

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

        public Point(string name,int x,int y):base(name)
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

        /// <summary>
        /// Override Object.Totring()
        /// Print Fields of the object data
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + GetInfo();
        }


    }
