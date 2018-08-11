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
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string ON = "*";
        private string OFF = "0";

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            ButtonCreate();
            Row = new string[] { OFF, OFF, OFF, OFF };
            Column = new string[] { OFF, OFF, OFF, OFF, OFF };
            LayoutGenerate(4, 4);
        }

        private string[] _column;

        public string[] Column
        {
            get { return _column; }
            set { _column = value; OnPropertyChanged(); }
        }

        private string[] _row;

        public string[] Row
        {
            get { return _row; }
            set { _row = value; OnPropertyChanged(); }
        }

        private void ButtonCreate()
        {
            Container.Children.OfType<Button>().Where(x => x.Uid == "Pass").ToList().ForEach(Button =>
            {
                Button.Content = "Pass";
                Button.Background = Brushes.Green;
            });

            Container.Children.OfType<Button>().Where(x => x.Uid == "Fail").ToList().ForEach(Button =>
            {
                Button.Content = "Fail";
                //Button.Background = Brushes.Red;
            });

            Container.Children.OfType<Button>().ToList().ForEach(Button =>
            {
                if (Button.Uid == "1")
                {
                    Button.Content = "Test";
                    Button.Background = Brushes.Honeydew;
                }
            });
        }

        private void LayoutGenerate(int x, int y)
        {
            var tempArray = Column;

            for (int i = 0; i < x; i++)
            {
                tempArray[i] = ON;
            }
            Column = tempArray;
            tempArray = Row;
            for (int i = 0; i < y; i++)
            {
                tempArray[i] = ON;
            }
            Row = tempArray;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Setings set = new Setings(this);
            this.Hide();
            set.Show();
        }

    }
}
