using System;
using System.Collections.Generic;
using System.Data;
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

namespace vosmerochka_ry
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        connect con = new connect();
        //private ListCollectionView view;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            string s = "SELECT * from products_k_import";
            grid.ItemsSource = con.ConDT(s).DefaultView;
        }

        private void grid_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        //Получаем данные из таблицы
        private void ContextMenu_insert(object sender, RoutedEventArgs e)
        {
            var item = grid.SelectedItem as DataRowView;
            string s = item.DataView[grid.SelectedIndex][0].ToString().Trim();
            MessageBox.Show(s);
        }
        //Получаем данные из таблицы
        private void ContextMenu_updeit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Изменение записи");
        }
        //Получаем данные из таблицы
        private void ContextMenu_delit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удаление записи");
        }
    }
}
