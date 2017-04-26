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
using DbApp.Models;
using System.Data.Entity;

namespace DbApp
{
    public partial class MainWindow : Window
    {
        MobileContext db;
        public MainWindow()
        {
            InitializeComponent();

            db = new MobileContext();
            db.Phones.Load(); // загружаем данные
            db.Firms.Load();
            phonesGrid.ItemsSource = db.Phones.Local.ToBindingList(); // устанавливаем привязку к кэшу
            FirmsGrid.ItemsSource = db.Firms.Local.ToBindingList(); 
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (phonesGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < phonesGrid.SelectedItems.Count; i++)
                {
                    Phone phone = phonesGrid.SelectedItems[i] as Phone;
                    if (phone != null)
                    {
                        db.Phones.Remove(phone);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}