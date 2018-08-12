using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfApp1
{
    class Draw
    {
        /// <summary>
        /// Rysuje panel glowny. W zaleznosci ile mamy produktow to dobieramy ilosc paneli w pionie i poziomie. Automatycznie wygenerowany zostanie pasek opcji na gorze i pasek do wysylania logow na dole.
        /// </summary>
        /// <param name="table">Nazwa Grida z pliku xaml na ktorej mamy rysowac</param>
        /// <param name="column"></param>
        /// <param name="row"></param>
        static public void DrawMainPanel(Grid table, int column, int row)
        {
            int height = 50;
            //RowDefinition first = new RowDefinition()
            //{
            //   MaxHeight = height,
            //   MinHeight = height
            //};
            //table.RowDefinitions.Add(first);
            for (int i = 0; i < column; i++)
            {
                table.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < row; i++)
            {
                table.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Button test = new Button()
                    {
                        Content = "Text"
                    };
                    Grid.SetColumn(test, i);
                    Grid.SetRow(test, j+1);
                    table.Children.Add(test);
                }
            }
            RowDefinition last = new RowDefinition()
            {
                MaxHeight = height,
                MinHeight = height
            };
            table.RowDefinitions.Add(last);
            DrawOptionPanel(table);
            DrawSendPanel(table);
        }

        static private void DrawOptionPanel(Grid table)
        {

        }

        static private void DrawSendPanel(Grid table)
        {

        }
    }
}
