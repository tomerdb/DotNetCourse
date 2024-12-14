using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WpfShapes = System.Windows.Shapes;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2.Models;public class Line : ShapeObject
{
    /// <summary>
    /// Gets or sets the font color of the line.
    /// </summary>
    public Brush FontColor { get; set; }

    /// <summary>
    /// Gets or sets the X-coordinate of the starting point.
    /// </summary>
    public double X1 { get { return X; } set { X = value; } }

    /// <summary>
    /// Gets or sets the Y-coordinate of the starting point.
    /// </summary>
    public double Y1 { get { return Y; } set { Y = value; } }

    /// <summary>
    /// Gets or sets the X-coordinate of the end point.
    /// </summary>
    public double X2 { get; set; }

    /// <summary>
    /// Gets or sets the Y-coordinate of the end point.
    /// </summary>
    public double Y2 { get; set; }

    /// <summary>
    /// Gets the type of the shape.
    /// </summary>
    public override string TypeShape => "Line";

    private WpfShapes.Line? _line;

    /// <summary>
    /// Initializes a new instance of the <see cref="Line"/> class with default values.
    /// </summary>
    public Line() : base(0, 0)
    {
        X2 = 100;
        Y2 = 100;
        FontColor = Brushes.Black;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Line"/> class with specified coordinates.
    /// </summary>
    /// <param name="x1">The X-coordinate of the starting point.</param>
    /// <param name="y1">The Y-coordinate of the starting point.</param>
    /// <param name="x2">The X-coordinate of the end point.</param>
    /// <param name="y2">The Y-coordinate of the end point.</param>
    public Line(double x1, double y1, double x2, double y2) : base(x1, y1)
    {
        X2 = x2;
        Y2 = y2;
        FontColor = Brushes.Black;
    }

    /// <summary>
    /// Creates the shape as a UIElement.
    /// </summary>
    /// <returns>The created shape as a UIElement.</returns>
    public override UIElement CreateShape()
    {
        _line = new WpfShapes.Line
        {
            X1 = X1,
            Y1 = Y1,
            X2 = X2,
            Y2 = Y2,
            Stroke = FontColor,
            StrokeThickness = 3,
        };
        Canvas.SetLeft(_line, X);
        Canvas.SetTop(_line, Y);
        // Attach the event handler
        _line.MouseLeftButtonDown += Line_MouseLeftButtonDown;

        ShapeElement = _line;
        return _line;
    }

    /// <summary>
    /// Handles the MouseLeftButtonDown event for the line.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void Line_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        // Handle the click event here
        UpdateLine updateLine = new UpdateLine();
        ((FrameworkElement)updateLine).Name = Name;
        if (Name != null) updateLine.NameTextBox.Text = Name;
        updateLine.X1TextBox.Text = X1.ToString(CultureInfo.InvariantCulture);
        updateLine.Y1TextBox.Text = Y1.ToString(CultureInfo.InvariantCulture);
        updateLine.X2TextBox.Text = X2.ToString(CultureInfo.InvariantCulture);
        updateLine.Y2TextBox.Text = Y2.ToString(CultureInfo.InvariantCulture);
        updateLine.Show();
        var addNewShapeWindow = Application.Current.Windows.OfType<AddNewShape>().FirstOrDefault();
        addNewShapeWindow?.Close();
    }

    /// <summary>
    /// Disables the mouse click event handler for the line.
    /// </summary>
    public void disableMouseClick()
    {
        if (_line != null)
        {
            _line.MouseLeftButtonDown -= Line_MouseLeftButtonDown;
        }
    }
}