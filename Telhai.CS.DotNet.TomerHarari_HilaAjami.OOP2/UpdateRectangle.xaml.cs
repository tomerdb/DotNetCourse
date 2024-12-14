using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2;

/// <summary>
/// Interaction logic for UpdateRectangle.xaml
/// </summary>
public partial class UpdateRectangle  
{
    /// <summary>
    /// Gets or sets the name of the rectangle.
    /// </summary>
    public new string? Name;

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateRectangle"/> class.
    /// </summary>
    public UpdateRectangle()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Handles the click event of the Update button.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void UpdateBtn_OnClick(object sender, RoutedEventArgs e)
    {
        var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
        var newName = NameTextBox.Text;
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
        mainWindow?.updateRectangle(newName, double.Parse(x), double.Parse(y), Name, double.Parse(width), double.Parse(height), fontColor);
        Close();
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