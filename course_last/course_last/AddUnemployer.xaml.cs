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
using System.Windows.Shapes;

namespace course_last
{
    /// <summary>
    /// Логика взаимодействия для AddUnemployer.xaml
    /// </summary>
    public partial class AddUnemployer : Window
    {
        public MainWindow owner;
        public AddUnemployer()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //if (.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
            //{


                //course_last.Database1DataSet database1DataSet = ((course_last.Database1DataSet)(this.FindResource("database1DataSet")));

                //course_last.Database1DataSetTableAdapters.InformationTableAdapter database1DataSetInformationTableAdapter = new course_last.Database1DataSetTableAdapters.InformationTableAdapter();
                //database1DataSetInformationTableAdapter.InsertQuery_Info(TBFirt_Name.Text, TBSurname.Text, Convert.ToInt32(TBYear.Text));
                //System.Windows.Data.CollectionViewSource informationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("informationViewSource")));
                //informationViewSource.View.MoveCurrentToFirst();


                //course_last.Database1DataSetTableAdapters.unemployedTableAdapter database1DataSetunemployedTableAdapter = new course_last.Database1DataSetTableAdapters.unemployedTableAdapter();
                //database1DataSetunemployedTableAdapter.InsertQuery_unemp(TBFirt_Name.Text, TBProfesion.Text, TBeducation.Text, TBrequirements.Text,TBPost.Text, TBPrevious_place.Text, TBWhyfired.Text,TBContacts.Text);
                //System.Windows.Data.CollectionViewSource unemployedViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("unemployedViewSource")));
                //unemployedViewSource.View.MoveCurrentToFirst();
               
            

           // }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
