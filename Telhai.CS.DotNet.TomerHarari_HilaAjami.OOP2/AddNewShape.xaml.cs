using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2;

/// <summary>
/// Interaction logic for AddNewShape.xaml
/// </summary>
public partial class AddNewShape
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AddNewShape"/> class.
    /// </summary>
    public AddNewShape()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Handles the selection changed event of the ComboBox.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Ensure there is a selected item
        if (e.AddedItems.Count > 0)
        {
            var selectedItem = e.AddedItems[0]; // Get the selected item
            foreach (var Object in AddNewShapeGrid.Children)
            {
                if (Object is FrameworkElement element)
                {
                    element.Visibility = Visibility.Collapsed;
                }
            }

            ChooseShapeLabel.Visibility = Visibility.Visible;
            CanvasBackground.Visibility = Visibility.Visible;
            ComboBox.Visibility = Visibility.Visible;
            NameTextBox.Visibility = Visibility.Visible;
            NameLabel.Visibility = Visibility.Visible;
            CreateNewShape.Visibility = Visibility.Visible;
            CancelBtn.Visibility = Visibility.Visible;
            ColorComboBox.Visibility = Visibility.Visible;
            ColorLabel.Visibility = Visibility.Visible;
            if (selectedItem != null && selectedItem.Equals(PointComboBox)) // Check if it's a ComboBoxItem
            {
                // Logic for when the point is selected
                XLabel.Visibility = Visibility.Visible;
                XTextBox.Visibility = Visibility.Visible;
                YLabel.Visibility = Visibility.Visible;
                YTextBox.Visibility = Visibility.Visible;
            }
            else if (selectedItem != null && selectedItem.Equals(LineComboBox))
            {
                // Logic for when the line is selected
                X1Label.Visibility = Visibility.Visible;
                X2Label.Visibility = Visibility.Visible;
                Y1Label.Visibility = Visibility.Visible;
                Y2Label.Visibility = Visibility.Visible;
                X1TextBox.Visibility = Visibility.Visible;
                X2TextBox.Visibility = Visibility.Visible;
                Y1TextBox.Visibility = Visibility.Visible;
                Y2TextBox.Visibility = Visibility.Visible;
            }
            else if (selectedItem != null && selectedItem.Equals(RectangleComboBox))
            {
                XLabel.Visibility = Visibility.Visible;
                YLabel.Visibility = Visibility.Visible;
                XTextBox.Visibility = Visibility.Visible;
                YTextBox.Visibility = Visibility.Visible;
                WidthLabel.Visibility = Visibility.Visible;
                WidthTextBox.Visibility = Visibility.Visible;
                HeightLabel.Visibility = Visibility.Visible;
                HeightTextBox.Visibility = Visibility.Visible;
            }
            else if (selectedItem != null && selectedItem.Equals(TextComboBox))
            {
                XLabel.Visibility = Visibility.Visible;
                YLabel.Visibility = Visibility.Visible;
                XTextBox.Visibility = Visibility.Visible;
                YTextBox.Visibility = Visibility.Visible;
                FontSizeTextBox.Visibility = Visibility.Visible;
                FontSizeLabel.Visibility = Visibility.Visible;
                TextBlockText.Visibility = Visibility.Visible;
                TextLabel.Visibility = Visibility.Visible;
            }
            else
            {
                // Handle other cases or unknown items
                MessageBox.Show("Unknown shape selected.");
            }
        }
    }

    /// <summary>
    /// Handles the click event of the CreateNewShape button.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void CreateNewShape_OnClick(object sender, RoutedEventArgs e)
    {
        var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
        var newName = NameTextBox.Text;

        if (ComboBox.SelectedItem.Equals(PointComboBox))
        {
            var x = XTextBox.Text;
            var y = YTextBox.Text;
            if (x.Equals("")) { x = "0"; }
            if (y.Equals("")) { y = "0"; }
            Brush fontColor;
            var color = (ColorComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            fontColor = color switch
            {
                "Red" => Brushes.Red,
                "Blue" => Brushes.Blue,
                "Green" => Brushes.Green,
                "Yellow" => Brushes.Yellow,
                _ => Brushes.Black
            };
            mainWindow?.addPoint(newName, double.Parse(x), double.Parse(y), fontColor);
            Close();
        }
        else if (ComboBox.SelectedItem.Equals(LineComboBox))
        {
            var x1 = X1TextBox.Text;
            var x2 = X2TextBox.Text;
            var y1 = Y1TextBox.Text;
            var y2 = Y2TextBox.Text;
            if (x1.Equals("")) { x1 = "0"; }
            if (y1.Equals("")) { y1 = "0"; }
            if (y2.Equals("")) { y2 = "100"; }
            if (x2.Equals("")) { x2 = "100"; }
            Brush fontColor;
            var color = (ColorComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            fontColor = color switch
            {
                "Red" => Brushes.Red,
                "Blue" => Brushes.Blue,
                "Green" => Brushes.Green,
                "Yellow" => Brushes.Yellow,
                _ => Brushes.Black
            };
            mainWindow?.addLine(double.Parse(x1), double.Parse(y1), double.Parse(x2), double.Parse(y2), newName, fontColor);
            Close();
        }
        else if (ComboBox.SelectedItem.Equals(RectangleComboBox))
        {
            var x = XTextBox.Text;
            var y = YTextBox.Text;
            var width = WidthTextBox.Text;
            var height = HeightTextBox.Text;
            if (x.Equals("")) { x = "0"; }
            if (y.Equals("")) { y = "0"; }
            if (width.Equals("")) { width = "100"; }
            if (height.Equals("")) { height = "50"; }
            Brush fontColor;
            var color = (ColorComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            fontColor = color switch
            {
                "Red" => Brushes.Red,
                "Blue" => Brushes.Blue,
                "Green" => Brushes.Green,
                "Yellow" => Brushes.Yellow,
                _ => Brushes.Black
            };
            mainWindow?.addRectangle(double.Parse(x), double.Parse(y), double.Parse(width), double.Parse(height), newName, fontColor);
            Close();
        }
        else if (ComboBox.SelectedItem.Equals(TextComboBox))
        {
            var x = XTextBox.Text;
            var y = YTextBox.Text;
            var text = TextBlockText.Text;
            var fontSize = FontSizeTextBox.Text;
            if (x.Equals("")) { x = "0"; }
            if (y.Equals("")) { y = "0"; }
            if (fontSize.Equals("")) { fontSize = "18"; }
            Brush fontColor;
            var color = (ColorComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            fontColor = color switch
            {
                "Red" => Brushes.Red,
                "Blue" => Brushes.Blue,
                "Green" => Brushes.Green,
                "Yellow" => Brushes.Yellow,
                _ => Brushes.Black
            };
            mainWindow?.addTextShape(double.Parse(x), double.Parse(y), text, int.Parse(fontSize), fontColor, newName);
            Close();
        }
    }

    /// <summary>
    /// Handles the click event of the Cancel button.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void CancelBtn_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}