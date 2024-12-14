using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2;

/// <summary>
/// Interaction logic for UpdatePoint.xaml
/// </summary>
public partial class UpdatePoint
{
    /// <summary>
    /// Gets or sets the name of the point.
    /// </summary>
    public new string? Name;

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdatePoint"/> class.
    /// </summary>
    public UpdatePoint()
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
        if (x.Equals("")) { x = "0";}
        if (y.Equals("")) { y = "0";}
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
        mainWindow?.updatePoint(newName, double.Parse(x), double.Parse(y), Name, fontColor);
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