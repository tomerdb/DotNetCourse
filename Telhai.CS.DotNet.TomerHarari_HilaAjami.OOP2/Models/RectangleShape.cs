using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WpfShapes = System.Windows.Shapes;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2.Models;public class RectangleShape : ShapeObject
{
    private WpfShapes.Rectangle? _rectangle;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public double Width { get; set; }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// Gets or sets the font color of the rectangle.
    /// </summary>
    public Brush FontColor { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RectangleShape"/> class with specified coordinates and dimensions.
    /// </summary>
    /// <param name="x">The x-coordinate of the rectangle.</param>
    /// <param name="y">The y-coordinate of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    public RectangleShape(double x, double y, double width, double height) : base(x, y)
    {
        Width = width;
        Height = height;
        FontColor = Brushes.Black;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RectangleShape"/> class with default values.
    /// </summary>
    public RectangleShape() : base(0, 0)
    {
        Width = 100;
        Height = 50;
    }

    /// <summary>
    /// Gets the type of the shape.
    /// </summary>
    public override string TypeShape => "Rectangle";

    /// <summary>
    /// Creates the shape as a UIElement.
    /// </summary>
    /// <returns>The created shape as a UIElement.</returns>
    public override UIElement CreateShape()
    {
        _rectangle = new WpfShapes.Rectangle
        {
            AllowDrop = true,
            Width = Width,
            Height = Height,
            StrokeThickness = 3,
            Stroke = FontColor
        };
        Canvas.SetLeft(_rectangle, X);
        Canvas.SetTop(_rectangle, Y);

        // Attach the event handler
        _rectangle.MouseLeftButtonDown += Rectangle_MouseLeftButtonDown;

        ShapeElement = _rectangle;
        return _rectangle;
    }

    /// <summary>
    /// Handles the MouseLeftButtonDown event for the rectangle.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        UpdateRectangle updateRectangle = new UpdateRectangle();
        if (Name != null)
        {
            updateRectangle.NameTextBox.Text = Name;
            ((FrameworkElement)updateRectangle).Name = Name;
        }

        updateRectangle.XTextBox.Text = X.ToString(CultureInfo.InvariantCulture);
        updateRectangle.YTextBox.Text = Y.ToString(CultureInfo.InvariantCulture);
        updateRectangle.WidthTextBox.Text = Width.ToString(CultureInfo.InvariantCulture);
        updateRectangle.HeightTextBox.Text = Height.ToString(CultureInfo.InvariantCulture);
        updateRectangle.Show();

        var addNewShapeWindow = Application.Current.Windows.OfType<AddNewShape>().FirstOrDefault();
        addNewShapeWindow?.Close();
    }

    /// <summary>
    /// Disables the mouse click event handler for the rectangle.
    /// </summary>
    public void disableMouseClick()
    {
        if (_rectangle != null) _rectangle.MouseLeftButtonDown -= Rectangle_MouseLeftButtonDown;
    }
}