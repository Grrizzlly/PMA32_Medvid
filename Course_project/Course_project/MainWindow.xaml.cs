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

using System.Data.Entity;
namespace Course_project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        employerContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new employerContext();
            db.unemployed_workers.Load(); // загружаемо данні
            db.full_employment_jobs.Load();
            db.underemployment_jobs.Load();
            db.Info.Load();//continue
            workersGrid.ItemsSource = db.unemployed_workers.Local.ToBindingList(); // устанавливаем привязку к кэшу
            // workersGrid.ItemsSource = db.full_employment_jobs.Local.ToBindingList();
            // workersGrid.ItemsSource = db.underemployment_jobs.Local.ToBindingList();
            // workersGrid.ItemsSource = db.Info.Local.ToBindingList();
            this.Closing += MainWindow_Closing;
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (workersGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < workersGrid.SelectedItems.Count; i++)
                {
                    unemployed unemp = workersGrid.SelectedItems[i] as unemployed;
                    if (unemp != null)
                    {
                        db.unemployed_workers.Remove(unemp);
                    }
                }
            }
            db.SaveChanges();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
