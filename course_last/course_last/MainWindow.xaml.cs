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
using course_last.Enteties;
namespace course_last
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InformationRepository repository = new InformationRepository();
       // IEnumerable<Information> Inform;
        List<Information> Inform;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            course_last.Database1DataSet database1DataSet = ((course_last.Database1DataSet)(this.FindResource("database1DataSet")));
            // Загрузить данные в таблицу Information. Можно изменить этот код как требуется.
            course_last.Database1DataSetTableAdapters.InformationTableAdapter database1DataSetInformationTableAdapter = new course_last.Database1DataSetTableAdapters.InformationTableAdapter();
            database1DataSetInformationTableAdapter.Fill(database1DataSet.Information);
            System.Windows.Data.CollectionViewSource informationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("informationViewSource")));
            informationViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу unemployed. Можно изменить этот код как требуется.
            course_last.Database1DataSetTableAdapters.unemployedTableAdapter database1DataSetunemployedTableAdapter = new course_last.Database1DataSetTableAdapters.unemployedTableAdapter();
            database1DataSetunemployedTableAdapter.Fill(database1DataSet.unemployed);
            System.Windows.Data.CollectionViewSource unemployedViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("unemployedViewSource")));
            unemployedViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Full_employment. Можно изменить этот код как требуется.
            course_last.Database1DataSetTableAdapters.Full_employmentTableAdapter database1DataSetFull_employmentTableAdapter = new course_last.Database1DataSetTableAdapters.Full_employmentTableAdapter();
            database1DataSetFull_employmentTableAdapter.Fill(database1DataSet.Full_employment);
            System.Windows.Data.CollectionViewSource full_employmentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("full_employmentViewSource")));
            full_employmentViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу undermployment. Можно изменить этот код как требуется.
            course_last.Database1DataSetTableAdapters.undermploymentTableAdapter database1DataSetundermploymentTableAdapter = new course_last.Database1DataSetTableAdapters.undermploymentTableAdapter();
            database1DataSetundermploymentTableAdapter.Fill(database1DataSet.undermployment);
            System.Windows.Data.CollectionViewSource undermploymentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("undermploymentViewSource")));
            undermploymentViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //AddUnemployer w = new AddUnemployer();
            //w.owner = this;
            //w.ShowDialog();
            //w.Close();

        }

        private void Btnrefresh_Click(object sender, RoutedEventArgs e)
        {
           
            course_last.Database1DataSet database1DataSet = ((course_last.Database1DataSet)(this.FindResource("database1DataSet")));
            // Загрузить данные в таблицу Information. Можно изменить этот код как требуется.
            course_last.Database1DataSetTableAdapters.InformationTableAdapter database1DataSetInformationTableAdapter = new course_last.Database1DataSetTableAdapters.InformationTableAdapter();
            database1DataSetInformationTableAdapter.Fill(database1DataSet.Information);
            System.Windows.Data.CollectionViewSource informationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("informationViewSource")));
            informationViewSource.View.MoveCurrentToFirst();

            course_last.Database1DataSetTableAdapters.unemployedTableAdapter database1DataSetunemployedTableAdapter = new course_last.Database1DataSetTableAdapters.unemployedTableAdapter();
            database1DataSetunemployedTableAdapter.Fill(database1DataSet.unemployed);
            System.Windows.Data.CollectionViewSource unemployedViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("unemployedViewSource")));
            unemployedViewSource.View.MoveCurrentToFirst();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            course_last.Database1DataSet database1DataSet = ((course_last.Database1DataSet)(this.FindResource("database1DataSet")));
            // Загрузить данные в таблицу Information. Можно изменить этот код как требуется.
          course_last.Database1DataSetTableAdapters.InformationTableAdapter database1DataSetInformationTableAdapter = new course_last.Database1DataSetTableAdapters.InformationTableAdapter();
            //   informationDataGrid.ItemsSource = null;


            database1DataSetInformationTableAdapter.DeleteQuery_Info(TextBox5.Text);
            // database1DataSetInformationTableAdapter.Fill(database1DataSet.Information);
            System.Windows.Data.CollectionViewSource informationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("informationViewSource")));
            informationViewSource.View.MoveCurrentToFirst();

            course_last.Database1DataSetTableAdapters.unemployedTableAdapter database1DataSetunemployedTableAdapter = new course_last.Database1DataSetTableAdapters.unemployedTableAdapter();
            database1DataSetunemployedTableAdapter.DeleteQuery_Unemployed(TextBox4.Text);
            System.Windows.Data.CollectionViewSource unemployedViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("unemployedViewSource")));
            unemployedViewSource.View.MoveCurrentToFirst();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (TBSurname.Text != "" && TBYear.Text != "" && TBFirt_Name.Text != "" && TBProfesion.Text != "" && TBeducation.Text != "" && TBrequirements.Text != "" && TBPost.Text != "" && TBPrevious_place.Text != "" && TBWhyfired.Text != ""  && TBContacts.Text!="")
            {
                
            course_last.Database1DataSet database1DataSet = ((course_last.Database1DataSet)(this.FindResource("database1DataSet")));

            course_last.Database1DataSetTableAdapters.InformationTableAdapter database1DataSetInformationTableAdapter = new course_last.Database1DataSetTableAdapters.InformationTableAdapter();
            database1DataSetInformationTableAdapter.InsertQuery_Info(TBFirt_Name.Text, TBSurname.Text, Convert.ToInt32(TBYear.Text));
            System.Windows.Data.CollectionViewSource informationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("informationViewSource")));
            informationViewSource.View.MoveCurrentToFirst();


            course_last.Database1DataSetTableAdapters.unemployedTableAdapter database1DataSetunemployedTableAdapter = new course_last.Database1DataSetTableAdapters.unemployedTableAdapter();
            database1DataSetunemployedTableAdapter.InsertQuery_unemp(TBFirt_Name.Text, TBProfesion.Text, TBeducation.Text, TBrequirements.Text, TBPost.Text, TBPrevious_place.Text, TBWhyfired.Text, TBContacts.Text);
            System.Windows.Data.CollectionViewSource unemployedViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("unemployedViewSource")));
            unemployedViewSource.View.MoveCurrentToFirst();
               
            }
            else MessageBox.Show("Fill all fields");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (TBSurname.Text != "" && TBYear.Text != "" && TBFirt_Name.Text != "" && TBProfesion.Text != "" && TBeducation.Text != "" && TBrequirements.Text != "" && TBPost.Text != "" && TBPrevious_place.Text != "" && TBWhyfired.Text != "" && TBContacts.Text != "")
            {

                course_last.Database1DataSet database1DataSet = ((course_last.Database1DataSet)(this.FindResource("database1DataSet")));

                course_last.Database1DataSetTableAdapters.InformationTableAdapter database1DataSetInformationTableAdapter = new course_last.Database1DataSetTableAdapters.InformationTableAdapter();
                database1DataSetInformationTableAdapter.InsertQuery_Info(TBFirt_Name.Text, TBSurname.Text, Convert.ToInt32(TBYear.Text));
                System.Windows.Data.CollectionViewSource informationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("informationViewSource")));
                informationViewSource.View.MoveCurrentToFirst();


                course_last.Database1DataSetTableAdapters.unemployedTableAdapter database1DataSetunemployedTableAdapter = new course_last.Database1DataSetTableAdapters.unemployedTableAdapter();
                database1DataSetunemployedTableAdapter.InsertQuery_unemp(TBFirt_Name.Text, TBProfesion.Text, TBeducation.Text, TBrequirements.Text, TBPost.Text, TBPrevious_place.Text, TBWhyfired.Text, TBContacts.Text);
                System.Windows.Data.CollectionViewSource unemployedViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("unemployedViewSource")));
                unemployedViewSource.View.MoveCurrentToFirst();

            }
            else MessageBox.Show("Fill all fields");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            course_last.Database1DataSet database1DataSet = ((course_last.Database1DataSet)(this.FindResource("database1DataSet")));
            // Загрузить данные в таблицу Information. Можно изменить этот код как требуется.
            course_last.Database1DataSetTableAdapters.InformationTableAdapter database1DataSetInformationTableAdapter = new course_last.Database1DataSetTableAdapters.InformationTableAdapter();
            //   informationDataGrid.ItemsSource = null;


            database1DataSetInformationTableAdapter.DeleteQuery_Info(TextBox5.Text);
            // database1DataSetInformationTableAdapter.Fill(database1DataSet.Information);
            System.Windows.Data.CollectionViewSource informationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("informationViewSource")));
            informationViewSource.View.MoveCurrentToFirst();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            course_last.Database1DataSet database1DataSet = ((course_last.Database1DataSet)(this.FindResource("database1DataSet")));
            // Загрузить данные в таблицу Information. Можно изменить этот код как требуется.
            course_last.Database1DataSetTableAdapters.InformationTableAdapter database1DataSetInformationTableAdapter = new course_last.Database1DataSetTableAdapters.InformationTableAdapter();
            database1DataSetInformationTableAdapter.Fill(database1DataSet.Information);
            System.Windows.Data.CollectionViewSource informationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("informationViewSource")));
            informationViewSource.View.MoveCurrentToFirst();

            course_last.Database1DataSetTableAdapters.unemployedTableAdapter database1DataSetunemployedTableAdapter = new course_last.Database1DataSetTableAdapters.unemployedTableAdapter();
            database1DataSetunemployedTableAdapter.Fill(database1DataSet.unemployed);
            System.Windows.Data.CollectionViewSource unemployedViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("unemployedViewSource")));
            unemployedViewSource.View.MoveCurrentToFirst();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnFind_Click(object sender, RoutedEventArgs e)
        {
                    }
    }
}
