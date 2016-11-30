using OsaulenkoEgor_Diceus_Test.Assets;
using OsaulenkoEgor_Diceus_Test.Configurations;
using OsaulenkoEgor_Diceus_Test.Model.AppModels;
using OsaulenkoEgor_Diceus_Test.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace OsaulenkoEgor_Diceus_Test.Views
{
    /// <summary>
    /// Interaction logic for TodoListView.xaml
    /// </summary>
    public partial class TodoListView : UserControl
    {
        TodoListViewModel _viewmodel = new TodoListViewModel();
        Widgets widget = new Widgets();

        public TodoListView()
        {
            InitializeComponent();
            dgTodoList.ItemsSource = _viewmodel.GetAllActiveTodos();
            tEmptyMessage.Visibility = dgTodoList.Items.Count > 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        private void btnDeactivate_Click(object sender, RoutedEventArgs e)
        {
            Todo selecteditem = dgTodoList.SelectedItem as Todo;
            _viewmodel.DeactivateTodo(selecteditem);
            dgTodoList.ItemsSource = null;
            dgTodoList.ItemsSource = _viewmodel.GetAllActiveTodos();
            tEmptyMessage.Visibility = dgTodoList.Items.Count > 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Todo selecteditem = dgTodoList.SelectedItem as Todo;
            List<Todo> _todolist = AppSession.Instance.GetValue<List<Todo>>("todolist");
            int index = _todolist.IndexOf(selecteditem);
            MainWindow mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.LoadControl(new InsertTodoView(index, selecteditem));
        }
    }
}
