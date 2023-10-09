using System;
using System.Collections.Generic;
using System.Windows;

namespace LogSplitter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FormatOutput(object sender, RoutedEventArgs e)
        {
            var names = new List<string>();

            foreach (string name in this.names.Text.Split('\n'))
            {
                names.Add(name); 
            }

            output.Text = "";
            foreach (string line in this.input.Text.Split('\n'))
            {
                foreach(string name in names)
                {
                    if (line.Trim().ToLower().Contains(name.Trim().ToLower()))
                    {
                        output.Text += line;
                        break;
                    }
                }
            }

        }
    }
}
