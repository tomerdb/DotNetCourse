using System.Globalization;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2.Models;
using Line = Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2.Models.Line;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly List<ShapeObject> _shapes;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            _shapes = new List<ShapeObject>();
        }

        /// <summary>
        /// Adds a new line to the canvas and list of shapes.
        /// </summary>
        /// <param name="x1">The X-coordinate of the starting point.</param>
        /// <param name="y1">The Y-coordinate of the starting point.</param>
        /// <param name="x2">The X-coordinate of the end point.</param>
        /// <param name="y2">The Y-coordinate of the end point.</param>
        /// <param name="name">The name of the line.</param>
        /// <param name="fontColor">The font color of the line.</param>
        public void addLine(double x1, double y1, double x2, double y2, string? name, Brush fontColor)
        {
            var line = new Line(x1, y1, x2, y2) { Name = name, FontColor = fontColor };
            _shapes.Add(line);
            CanvasShapes.Children.Add(line.CreateShape());
            LstBoxShapes.Items.Add(line);
        }

        /// <summary>
        /// Adds a new point to the canvas and list of shapes.
        /// </summary>
        /// <param name="name">The name of the point.</param>
        /// <param name="x">The X-coordinate of the point.</param>
        /// <param name="y">The Y-coordinate of the point.</param>
        /// <param name="fontColor">The font color of the point.</param>
        public void addPoint(string name, double x, double y, Brush fontColor)
        {
            var point = new Models.Point(x, y) { Name = name, FontColor = fontColor };
            _shapes.Add(point);
            CanvasShapes.Children.Add(point.CreateShape());
            LstBoxShapes.Items.Add(point);
        }

        /// <summary>
        /// Adds a new rectangle to the canvas and list of shapes.
        /// </summary>
        /// <param name="x">The X-coordinate of the rectangle.</param>
        /// <param name="y">The Y-coordinate of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="newName">The name of the rectangle.</param>
        /// <param name="fontColor">The font color of the rectangle.</param>
        public void addRectangle(double x, double y, double width, double height, string newName, Brush fontColor)
        {
            var rect = new RectangleShape(x, y, width, height) { Name = newName, FontColor = fontColor };
            _shapes.Add(rect);
            CanvasShapes.Children.Add(rect.CreateShape());
            LstBoxShapes.Items.Add(rect);
        }

        /// <summary>
        /// Adds a new text shape to the canvas and list of shapes.
        /// </summary>
        /// <param name="x">The X-coordinate of the text shape.</param>
        /// <param name="y">The Y-coordinate of the text shape.</param>
        /// <param name="text">The text of the shape.</param>
        /// <param name="fontSize">The font size of the text.</param>
        /// <param name="fontColor">The font color of the text.</param>
        /// <param name="newName">The name of the text shape.</param>
        public void addTextShape(double x, double y, string text, int fontSize, Brush fontColor, string newName)
        {
            var textShape = new TextShape(text, fontSize, x, y) { Name = newName, FontColor = fontColor };
            _shapes.Add(textShape);
            CanvasShapes.Children.Add(textShape.CreateShape());
            LstBoxShapes.Items.Add(textShape);
        }

        /// <summary>
        /// Updates an existing rectangle's properties.
        /// </summary>
        /// <param name="newName">The new name of the rectangle.</param>
        /// <param name="x">The new X-coordinate of the rectangle.</param>
        /// <param name="y">The new Y-coordinate of the rectangle.</param>
        /// <param name="oldName">The old name of the rectangle.</param>
        /// <param name="width">The new width of the rectangle.</param>
        /// <param name="height">The new height of the rectangle.</param>
        /// <param name="fontColor">The new font color of the rectangle.</param>
        public void updateRectangle(string newName, double x, double y, string? oldName, double width, double height, Brush fontColor)
        {
            foreach (var shapeObject in _shapes)
            {
                if (shapeObject is RectangleShape rectangle && shapeObject.Name != null && shapeObject.Name == oldName)
                {
                    _shapes.Remove(shapeObject);
                    LstBoxShapes.Items.Remove(shapeObject);
                    CanvasShapes.Children.Remove(shapeObject.ShapeElement);

                    rectangle.X = x;
                    rectangle.Y = y;
                    rectangle.Width = width;
                    rectangle.Height = height;
                    rectangle.Name = newName;
                    rectangle.FontColor = fontColor;

                    CanvasShapes.Children.Add(rectangle.CreateShape());
                    _shapes.Add(rectangle);
                    LstBoxShapes.Items.Add(rectangle);

                    break;
                }
            }
        }

        /// <summary>
        /// Updates an existing text shape's properties.
        /// </summary>
        /// <param name="newName">The new name of the text shape.</param>
        /// <param name="x">The new X-coordinate of the text shape.</param>
        /// <param name="y">The new Y-coordinate of the text shape.</param>
        /// <param name="text">The new text of the shape.</param>
        /// <param name="fontSize">The new font size of the text.</param>
        /// <param name="fontColor">The new font color of the text.</param>
        /// <param name="oldName">The old name of the text shape.</param>
        public void updateTextShape(string newName, double x, double y, string text, int fontSize, Brush fontColor, string oldName)
        {
            foreach (var shapeObject in _shapes)
            {
                if (shapeObject is TextShape textShape && shapeObject.Name != null && shapeObject.Name == oldName)
                {
                    _shapes.Remove(shapeObject);
                    LstBoxShapes.Items.Remove(shapeObject);
                    CanvasShapes.Children.Remove(shapeObject.ShapeElement);

                    textShape.X = x;
                    textShape.Y = y;
                    textShape.Name = newName;
                    textShape.FontSize = fontSize;
                    textShape.FontColor = fontColor;
                    textShape.Text = text;

                    CanvasShapes.Children.Add(textShape.CreateShape());
                    _shapes.Add(textShape);
                    LstBoxShapes.Items.Add(textShape);

                    break;
                }
            }
        }

        /// <summary>
        /// Updates an existing point's properties.
        /// </summary>
        /// <param name="newName">The new name of the point.</param>
        /// <param name="x">The new X-coordinate of the point.</param>
        /// <param name="y">The new Y-coordinate of the point.</param>
        /// <param name="oldName">The old name of the point.</param>
        /// <param name="fontColor">The new font color of the point.</param>
        public void updatePoint(string newName, double x, double y, string? oldName, Brush fontColor)
        {
            foreach (var shapeObject in _shapes)
            {
                if (shapeObject is Models.Point point && shapeObject.Name != null && shapeObject.Name == oldName)
                {
                    _shapes.Remove(shapeObject);
                    LstBoxShapes.Items.Remove(shapeObject);
                    CanvasShapes.Children.Remove(shapeObject.ShapeElement);

                    point.X = x;
                    point.Y = y;
                    point.Name = newName;
                    point.FontColor = fontColor;

                    CanvasShapes.Children.Add(shapeObject.CreateShape());
                    _shapes.Add(shapeObject);
                    LstBoxShapes.Items.Add(shapeObject);

                    break;
                }
            }
        }

        /// <summary>
        /// Updates an existing line's properties.
        /// </summary>
        /// <param name="newName">The new name of the line.</param>
        /// <param name="x1">The new X-coordinate of the starting point.</param>
        /// <param name="y1">The new Y-coordinate of the starting point.</param>
        /// <param name="x2">The new X-coordinate of the end point.</param>
        /// <param name="y2">The new Y-coordinate of the end point.</param>
        /// <param name="oldName">The old name of the line.</param>
        /// <param name="fontColor">The new font color of the line.</param>
        public void updateLine(string newName, double x1, double y1, double x2, double y2, string? oldName, Brush fontColor)
        {
            foreach (var shapeObject in _shapes)
            {
                if (shapeObject is Line line && shapeObject.Name != null && shapeObject.Name == oldName)
                {
                    _shapes.Remove(shapeObject);
                    LstBoxShapes.Items.Remove(shapeObject);
                    CanvasShapes.Children.Remove(shapeObject.ShapeElement);

                    line.X1 = x1;
                    line.Y1 = y1;
                    line.X2 = x2;
                    line.Y2 = y2;
                    line.Name = newName;
                    line.FontColor = fontColor;

                    CanvasShapes.Children.Add(line.CreateShape());
                    _shapes.Add(line);
                    LstBoxShapes.Items.Add(line);

                    break;
                }
            }
        }

        /// <summary>
        /// Opens the AddNewShape window.
        /// </summary>
        private void BtnAddNewShape_Click(object sender, RoutedEventArgs e)
        {
            var addNewShape = new AddNewShape();
            addNewShape.Show();
        }

        /// <summary>
        /// Removes the selected shape from the canvas and list of shapes.
        /// </summary>
        private void removeSelectedItem(object sender, RoutedEventArgs e)
        {
            if (LstBoxShapes.SelectedItem is ShapeObject selectedShape)
            {
                if (_shapes.Contains(selectedShape))
                {
                    _shapes.Remove(selectedShape);
                }

                LstBoxShapes.Items.Remove(selectedShape);
                CanvasShapes.Children.Remove(selectedShape.ShapeElement);
            }
            else
            {
                MessageBox.Show("Please select a shape to remove.");
            }
        }

        /// <summary>
        /// Handles double-click event on the list box to update the selected shape.
        /// </summary>
        private void lstBoxShapes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LstBoxShapes.SelectedItem is ShapeObject shape)
            {
                if (shape.TypeShape == "Point")
                {
                    UpdatePoint updateShape = new UpdatePoint();
                    if (shape.Name != null)
                    {
                        updateShape.NameTextBox.Text = shape.Name;
                        ((FrameworkElement)updateShape).Name = shape.Name;
                    }

                    updateShape.XTextBox.Text = shape.X.ToString(CultureInfo.InvariantCulture);
                    updateShape.YTextBox.Text = shape.Y.ToString(CultureInfo.InvariantCulture);
                    updateShape.Show();

                    var addNewShapeWindow = Application.Current.Windows.OfType<AddNewShape>().FirstOrDefault();
                    if (addNewShapeWindow != null)
                    {
                        addNewShapeWindow.Close();
                    }
                }
                else if (shape.TypeShape == "Line")
                {
                    UpdateLine updateLine = new UpdateLine();
                    ((FrameworkElement)updateLine).Name = shape.Name;
                    if (shape.Name != null) updateLine.NameTextBox.Text = shape.Name;
                    updateLine.X1TextBox.Text = ((Line)shape).X1.ToString(CultureInfo.InvariantCulture);
                    updateLine.Y1TextBox.Text = ((Line)shape).Y1.ToString(CultureInfo.InvariantCulture);
                    updateLine.X2TextBox.Text = ((Line)shape).X2.ToString(CultureInfo.InvariantCulture);
                    updateLine.Y2TextBox.Text = ((Line)shape).Y2.ToString(CultureInfo.InvariantCulture);
                    updateLine.Show();
                    var addNewShapeWindow = Application.Current.Windows.OfType<AddNewShape>().FirstOrDefault();
                    addNewShapeWindow?.Close();
                }
                else if (shape.TypeShape == "Rectangle")
                {
                    UpdateRectangle updateRectangle = new UpdateRectangle();
                    ((FrameworkElement)updateRectangle).Name = shape.Name;
                    if (shape.Name != null) updateRectangle.NameTextBox.Text = shape.Name;
                    updateRectangle.XTextBox.Text = ((RectangleShape)shape).X.ToString(CultureInfo.InvariantCulture);
                    updateRectangle.YTextBox.Text = ((RectangleShape)shape).Y.ToString(CultureInfo.InvariantCulture);
                    updateRectangle.WidthTextBox.Text = ((RectangleShape)shape).Width.ToString(CultureInfo.InvariantCulture);
                    updateRectangle.HeightTextBox.Text = ((RectangleShape)shape).Height.ToString(CultureInfo.InvariantCulture);
                    updateRectangle.Show();
                    var addNewShapeWindow = Application.Current.Windows.OfType<AddNewShape>().FirstOrDefault();
                    addNewShapeWindow?.Close();
                }
                else
                {
                    UpdateTextShape updateTextShape = new UpdateTextShape();
                    ((FrameworkElement)updateTextShape).Name = shape.Name;
                    if (shape.Name != null) updateTextShape.NameTextBox.Text = shape.Name;
                    updateTextShape.XTextBox.Text = ((TextShape)shape).X.ToString(CultureInfo.InvariantCulture);
                    updateTextShape.YTextBox.Text = ((TextShape)shape).Y.ToString(CultureInfo.InvariantCulture);
                    updateTextShape.TextBlockText.Text = ((TextShape)shape).Text;
                    updateTextShape.FontSizeTextBox.Text = ((TextShape)shape).FontSize.ToString(CultureInfo.InvariantCulture);
                    updateTextShape.Show();
                    var addNewShapeWindow = Application.Current.Windows.OfType<AddNewShape>().FirstOrDefault();
                    addNewShapeWindow?.Close();
                }
            }
        }

        /// <summary>
        /// Handles left button down event on the list box to update the window title.
        /// </summary>
        private void lstBoxShapes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                if (LstBoxShapes.SelectedItem != null)
                {
                    Title = LstBoxShapes.SelectedItem.ToString();
                }
            }));
        }
    }
}