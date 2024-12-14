using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2.Models
{
    public class Point : ShapeObject
    {
        private Ellipse? _point;
        public Brush FontColor { get; set; } = Brushes.Black;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class with default values.
        /// </summary>
        public Point() : base(0, 0) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class with specified coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate of the point.</param>
        /// <param name="y">The y-coordinate of the point.</param>
        public Point(double x, double y) : base(x, y)
        {
            FontColor = Brushes.Black;
        }

        /// <summary>
        /// Gets the type of the shape.
        /// </summary>
        public override string TypeShape => "Point";

        /// <summary>
        /// Creates the shape as a UIElement.
        /// </summary>
        /// <returns>The created shape as a UIElement.</returns>
        public override UIElement CreateShape()
        {
            _point = new Ellipse
            {
                Width = 10,
                Height = 10,
                Fill = FontColor
            };

            Canvas.SetLeft(_point, X);
            Canvas.SetTop(_point, Y);

            // Attach the event handler
            _point.MouseLeftButtonDown += Point_MouseLeftButtonDown;

            ShapeElement = _point;
            return _point;
        }

        /// <summary>
        /// Handles the MouseLeftButtonDown event for the point.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void Point_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UpdatePoint updateShape = new UpdatePoint();
            if (Name != null)
            {
                updateShape.NameTextBox.Text = Name;
                ((FrameworkElement)updateShape).Name = Name;
            }

            updateShape.XTextBox.Text = X.ToString(CultureInfo.InvariantCulture);
            updateShape.YTextBox.Text = Y.ToString(CultureInfo.InvariantCulture);
            updateShape.Show();

            var addNewShapeWindow = Application.Current.Windows.OfType<AddNewShape>().FirstOrDefault();
            addNewShapeWindow?.Close();
        }

        /// <summary>
        /// Disables the mouse click event handler for the point.
        /// </summary>
        public void disableMouseClick()
        {
            if (_point != null) _point.MouseLeftButtonDown -= Point_MouseLeftButtonDown;
        }
    }
}