using System.Windows;

namespace Telhai.cs.DotNet.TomerHarari.DataTypesApp
{
    public partial class MainWindow : Window
    {
        // Declare a list to hold the points
        private List<Point> pointsList = new List<Point>();
        bool flag = false;

        /// <summary>
        /// Constructor for the MainWindow class.
        /// Initializes the window and its components.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Appends a line of text to the log box, followed by a newline.
        /// </summary>
        /// <param name="txt">The text to append.</param>
        private void LogTextLine(string txt)
        {
            txtLogBox.Text += txt + Environment.NewLine;
        }

        /// <summary>
        /// Appends the string representation of an object to the log box, followed by a newline.
        /// </summary>
        /// <param name="objPoint">The object to log.</param>
        private void LogTextLine(object objPoint)
        {
            txtLogBox.Text += objPoint.ToString() + Environment.NewLine;
        }

        /// <summary>
        /// Appends text to the log box without adding a newline.
        /// </summary>
        /// <param name="txt">The text to append.</param>
        private void LogText(string txt)
        {
            txtLogBox.Text += txt;
        }

        /// <summary>
        /// Handles the click event for the "Test" button.
        /// Parses X and Y values from input fields, validates them, 
        /// and logs a point if the values are valid.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">Event data.</param>
        private void test_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            int y = 0;
            bool isError = false;
            try
            {
                x = int.Parse(txtBoxX.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("X is not a number");
                isError = true;
            }

            bool isOkParsed = int.TryParse(txtBoxY.Text, out y);
            if (!isOkParsed)
            {
                MessageBox.Show("Y is not a number");
                isError = true;
            }

            // No Error
            if (!isError)
            {
                Point p = new Point(x, y);
                LogTextLine(p);
            }
        }

        /// <summary>
        /// Handles the click event for the "Random" button.
        /// Generates a random point, adds it to the list, 
        /// and logs all points in the list.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">Event data.</param>
        private void random_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Point newPoint = new Point(r.Next(101), r.Next(101));
            pointsList.Add(newPoint);

            LogAllPoints();
        }

        /// <summary>
        /// Handles the click event for the "Add to Array" button.
        /// Parses X and Y values from input fields, validates them, 
        /// adds a new point to the list, and logs all points.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">Event data.</param>
        private void addToArr(object sender, RoutedEventArgs e)
        {
            int x, y;

            if (!TryParseInput(txtBoxX.Text, out x, "X"))
                return;

            if (!TryParseInput(txtBoxY.Text, out y, "Y"))
                return;

            Point newPoint = new Point(x, y);
            pointsList.Add(newPoint);

            LogAllPoints();
        }

        /// <summary>
        /// Logs all points in the list. If the flag is true, 
        /// it calculates and logs the total difference between points.
        /// Updates the total_diff label with the total difference.
        /// </summary>
        private void LogAllPoints()
        {
            txtLogBox.Text += Environment.NewLine + "Points in the List:" + Environment.NewLine;
            if (pointsList.Count == 0)
            {
                txtLogBox.Text += "Empty" + Environment.NewLine;
                total_diff.Content = "Total Diff:";
            }
            else
            {
                double totalDiff = 0;
                for (int i = 0; i < pointsList.Count; i++)
                {
                    if (i < 1)
                    {
                        txtLogBox.Text += $"({pointsList[i].X}, {pointsList[i].Y})" + Environment.NewLine;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            totalDiff += Math.Sqrt(
                                Math.Pow(pointsList[i].X - pointsList[j].X, 2) +
                                Math.Pow(pointsList[i].Y - pointsList[j].Y, 2)
                            );
                        }

                        if (flag)
                        {
                            txtLogBox.Text += $"({pointsList[i].X}, {pointsList[i].Y}) " +
                                              $" total diff: {totalDiff:F2}" +
                                              Environment.NewLine;
                        }
                        else
                        {
                            txtLogBox.Text += $"({pointsList[i].X}, {pointsList[i].Y}) " +
                                              Environment.NewLine;
                        }
                    }
                }
                total_diff.Content = $"Total Diff: {totalDiff.ToString("F2")}";
            }
        }

        /// <summary>
        /// Tries to parse a string as an integer. 
        /// If parsing fails, it displays an error message.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <param name="result">The parsed integer, if successful.</param>
        /// <param name="fieldName">The name of the field for the error message.</param>
        /// <returns>True if parsing is successful, otherwise false.</returns>
        private bool TryParseInput(string input, out int result, string fieldName)
        {
            if (int.TryParse(input, out result))
                return true;

            MessageBox.Show($"{fieldName} is not a number");
            return false;
        }

        /// <summary>
        /// Handles the click event for the "Reset" button.
        /// Clears the list of points and logs the empty list.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">Event data.</param>
        private void reset_click(object sender, RoutedEventArgs e)
        {
            pointsList = new List<Point>();

            LogAllPoints();
        }

        /// <summary>
        /// Handles the click event for the checkbox.
        /// Toggles the flag to show/hide the total difference in the log, 
        /// and logs all points with the updated setting.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">Event data.</param>
        private void checkBox_click(object sender, RoutedEventArgs e)
        {
            flag = !flag;
            LogAllPoints();
        }
    }
}
