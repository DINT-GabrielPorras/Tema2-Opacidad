using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Opacidad
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

        public void EpisodioIV_MouseEnter(Object sender, MouseEventArgs e) 
        {
            if(sender == episodioIV)
                episodioIV.Opacity = 1;
        }
        public void EpisodioIV_MouseLeave(Object sender, MouseEventArgs e)
        {
            if (sender == episodioIV)
                episodioIV.Opacity = 0.5;
        }
        public void EpisodioV_MouseEnter(Object sender, MouseEventArgs e)
        {
            if (sender == episodioV)
                episodioV.Opacity = 1;
        }
        public void EpisodioV_MouseLeave(Object sender, MouseEventArgs e)
        {
            if (sender == episodioV)
                episodioV.Opacity = 0.5;
        }
        public void EpisodioVI_MouseEnter(Object sender, MouseEventArgs e)
        {
            if (sender == episodioVI)
                episodioVI.Opacity = 1;
        }
        public void EpisodioVI_MouseLeave(Object sender, MouseEventArgs e)
        {
            if (sender == episodioVI)
                episodioVI.Opacity = 0.5;
        }


    }
}
