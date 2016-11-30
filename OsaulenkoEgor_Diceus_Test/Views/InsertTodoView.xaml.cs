using OsaulenkoEgor_Diceus_Test.Assets;
using OsaulenkoEgor_Diceus_Test.Model.AppModels;
using OsaulenkoEgor_Diceus_Test.ViewModels;
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

namespace OsaulenkoEgor_Diceus_Test.Views
{
    /// <summary>
    /// Interaction logic for InsertTodoView.xaml
    /// </summary>
    public partial class InsertTodoView : UserControl
    {
        Widgets widget = new Widgets();
        InsertTodoViewModel _viewmodel;
        Todo _currentodo;
        bool _isnewrecord;
        int _index;


        public InsertTodoView()
        {
            InitializeComponent();
            _isnewrecord = true;
            _viewmodel = new InsertTodoViewModel();
            _currentodo = new Todo();
        }

        public InsertTodoView(int index, Todo todo)
        {
            InitializeComponent();
            _isnewrecord = false;
            _viewmodel = new InsertTodoViewModel();
            _currentodo = todo;
            _index = index;
            PrefillData(todo);
            tbMessageWatermark.Visibility = Visibility.Collapsed;
            tbTitleWatermark.Visibility = Visibility.Collapsed;
        }

        private void PrefillData(Todo todo)
        {
            tbTitle.Text = todo.Title;
            tbMessage.Text = todo.Message;
            dpExecute.Text = todo.TimeExecute.ToShortDateString();
        }

        private void lblSave_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(ValidateFields())
            {
                _currentodo = new Todo()
                {
                    Active = true,
                    TimeCreated = DateTime.Now,
                    TimeExecute = dpExecute.SelectedDate.Value,
                    Title = tbTitle.Text,
                    Message = tbMessage.Text
                };

                if (_isnewrecord)
                {
                    _viewmodel.SaveNewTodo(_currentodo);
                }
                else
                {
                    _viewmodel.UpdateTodo(_index, _currentodo);
                }
                MainWindow mainwindow = Application.Current.MainWindow as MainWindow;
                mainwindow.LoadControl(new TodoListView());
            }
        }

        private void lblCancel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainwindow = Application.Current.MainWindow as MainWindow;
            mainwindow.LoadControl(new TodoListView());
        }

        private bool ValidateFields()
        {
            return string.IsNullOrEmpty(tbTitle.Text) || string.IsNullOrEmpty(tbMessage.Text) || string.IsNullOrEmpty(dpExecute.Text) ? false : true;
        }

        private void WatermarkCmbBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            widget.Combobox_Watermark(sender, this);
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            widget.TextBox_GotFocus(sender, this);
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            widget.TextBox_LostFocus(sender, this);
        }
    }
}
