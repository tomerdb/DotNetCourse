using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2;

/// <summary>
/// Interaction logic for UpdateLine.xaml
/// </summary>
public partial class UpdateLine
{
    /// <summary>
    /// Gets or sets the name of the line.
    /// </summary>
    public new string? Name;

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateLine"/> class.
    /// </summary>
    public UpdateLine()
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
        var x1 = X1TextBox.Text;
        var x2 = X2TextBox.Text;
        var y1 = Y1TextBox.Text;
        var y2 = Y2TextBox.Text;
        if (x1.Equals("")) { x1 = "0";}
        if (y1.Equals("")) { y1 = "0";}
        if (y2.Equals("")) { y2 = "100";}
        if (x2.Equals("")) { x2 = "100";}
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
        mainWindow?.updateLine(newName, double.Parse(x1), double.Parse(y1), double.Parse(x2), double.Parse(y2), Name, fontColor);
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