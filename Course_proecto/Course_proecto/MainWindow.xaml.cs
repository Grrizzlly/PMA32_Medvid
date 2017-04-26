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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Course_proecto.Models;
using System.Data.Entity;
namespace Course_proecto
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContextWorkers db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ContextWorkers();
            db.Workerrs.Load(); // загружаем данные
            phonesGrid.ItemsSource = db.Workerrs.Local.ToBindingList(); // устанавливаем привязку к кэшу

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
                    Workers workerstemp = phonesGrid.SelectedItems[i] as Workers;
                    if (workerstemp != null)
                    {
                        db.Workerrs.Remove(workerstemp);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
