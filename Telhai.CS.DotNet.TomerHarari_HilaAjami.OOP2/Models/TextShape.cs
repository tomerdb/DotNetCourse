using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2.Models
{
    /// <summary>
    /// Represents a text shape.
    /// </summary>
    public class TextShape : ShapeObject
    {
        private TextBlock? _textBlock;

        /// <summary>
        /// Gets or sets the text of the shape.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the font size of the text.
        /// </summary>
        public double FontSize { get; set; }

        /// <summary>
        /// Gets or sets the font color of the text.
        /// </summary>
        public Brush FontColor { get; set; }

        /// <summary>
        /// Gets the type of the shape.
        /// </summary>
        public override string TypeShape => "TextShape";

        /// <summary>
        /// Initializes a new instance of the <see cref="TextShape"/> class with default values.
        /// </summary>
        public TextShape() : base(0, 0)
        {
            Text = "Default Text";
            FontSize = 12;
            FontColor = Brushes.Black;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextShape"/> class with specified values.
        /// </summary>
        /// <param name="text">The text of the shape.</param>
        /// <param name="fontSize">The font size of the text.</param>
        /// <param name="x">The X-coordinate of the shape.</param>
        /// <param name="y">The Y-coordinate of the shape.</param>
        public TextShape(string text, double fontSize, double x = 0, double y = 0) : base(x, y)
        {
            Text = text;
            FontSize = fontSize;
            FontColor = Brushes.Black;
        }

        /// <summary>
        /// Creates the shape as a UIElement.
        /// </summary>
        /// <returns>The created shape as a UIElement.</returns>
        public override UIElement CreateShape()
        {
            _textBlock = new TextBlock
            {
                Text = this.Text,
                FontSize = this.FontSize,
                Foreground = this.FontColor,
            };
            Canvas.SetLeft(_textBlock, X);
            Canvas.SetTop(_textBlock, Y);
            ShapeElement = _textBlock;

            // Attach the event handler
            _textBlock.MouseLeftButtonDown += TextShape_MouseLeftButtonDown;

            return _textBlock;
        }

        /// <summary>
        /// Handles the MouseLeftButtonDown event for the text shape.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void TextShape_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UpdateTextShape updateTextShape = new UpdateTextShape();
            if (Name != null)
            {
                updateTextShape.NameTextBox.Text = Name;
                ((FrameworkElement)updateTextShape).Name = Name;
            }

            updateTextShape.XTextBox.Text = X.ToString(CultureInfo.InvariantCulture);
            updateTextShape.YTextBox.Text = Y.ToString(CultureInfo.InvariantCulture);
            updateTextShape.TextBlockText.Text = Text;
            updateTextShape.FontSize = FontSize;
            updateTextShape.FontSizeTextBox.Text = FontSize.ToString(CultureInfo.InvariantCulture);
            updateTextShape.Show();

            var addNewShapeWindow = Application.Current.Windows.OfType<AddNewShape>().FirstOrDefault();
            addNewShapeWindow?.Close();
        }

        /// <summary>
        /// Disables the mouse click event handler for the text shape.
        /// </summary>
        public void disableMouseClick()
        {
            if (_textBlock != null) _textBlock.MouseLeftButtonDown -= TextShape_MouseLeftButtonDown;
        }
    }
}