using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DevisSolGUI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new RootViewModel();
        }

        private void CloseCross_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimize_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            WindowStyle = WindowStyle.SingleBorderWindow;
            WindowState = System.Windows.WindowState.Minimized;
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

    }
}