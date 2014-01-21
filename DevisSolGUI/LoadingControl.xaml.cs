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
    /// Logique d'interaction pour LoadingControl.xaml
    /// </summary>
    public partial class LoadingControl : UserControl
    {
        public LoadingControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty StartAnimProperty = DependencyProperty.Register("StartAnim", typeof(Boolean), typeof(LoadingControl), new PropertyMetadata(false));

        public Boolean StartAnim
        {
            get { return (Boolean)GetValue(StartAnimProperty); }
            set { SetValue(StartAnimProperty, value); }
        }

        public static readonly DependencyProperty LeaveAnimProperty = DependencyProperty.Register("LeaveAnim", typeof(Boolean), typeof(LoadingControl), new PropertyMetadata(false));

        public Boolean LeaveAnim
        {
            get { return (Boolean)GetValue(LeaveAnimProperty); }
            set { SetValue(StartAnimProperty, value); }
        }
    }
}