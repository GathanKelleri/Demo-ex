using System.Windows;
using KafedraApp.Data;

namespace KafedraApp
{
    public partial class MainWindow : Window
    {
        private readonly DbReader _dbReader;

        public MainWindow(DbReader dbReader)
        {
            _dbReader = dbReader;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            TeachersDataGrid.ItemsSource = _dbReader.GetTeachers();
            LoadDataGrid.ItemsSource = _dbReader.GetTeacherLoad();
        }
    }
}
