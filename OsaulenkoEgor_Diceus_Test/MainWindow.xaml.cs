using OsaulenkoEgor_Diceus_Test.Assets;
using OsaulenkoEgor_Diceus_Test.Configurations;
using OsaulenkoEgor_Diceus_Test.Model.AppModels;
using OsaulenkoEgor_Diceus_Test.Model.DataRetrieval;
using OsaulenkoEgor_Diceus_Test.Views;
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

namespace OsaulenkoEgor_Diceus_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TodoDataRetrieval _dataRetrievalTodo = new TodoDataRetrieval();
        List<Todo> _todolist = new List<Todo>();
        Widgets widget = new Widgets();

        public MainWindow()
        {
            InitializeComponent();
            AppSession.Instance.SetValue("todolist", _todolist);
            widget.LoadItems();
            LoadControl(new TodoListView());
        }
        /// <summary>
        /// Loads the views.
        /// </summary>
        /// <param x:Name="control">View</param>
        public void LoadControl(UserControl control)
        {
            controlHolder.Children.Clear();
            controlHolder.Children.Add(control);
        }
        /// <summary>
        /// Shows the preloader.
        /// </summary>
        public void preloaderShow()
        {
            if (preloader.Visibility == Visibility.Hidden)
            {
                preloader.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Hides the preloader.
        /// </summary>
        public void preloaderHide()
        {
            if (preloader.Visibility == Visibility.Visible)
            {
                preloader.Visibility = Visibility.Hidden;
            }
        }
        /// <summary>
        /// Closes the application.
        /// </summary>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary>
        /// Minimizes the application to tray.
        /// </summary>
        internal void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        /// <summary>
        /// Application header MouseDown action management.
        /// </summary>
        private void RootWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        /// <summary>
        /// Maximizes the window to fullscreen.
        /// </summary>
        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            AdjustWindowSize();
        }
        /// <summary>
        /// Adjust the application window dimensions.
        /// </summary>
        private void AdjustWindowSize()
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                dckpnlRoot.Visibility = Visibility.Visible;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                dckpnlRoot.Visibility = Visibility.Collapsed;
            }
        }
        /// <summary>
        /// Manages Alt+Enter application window maximization and restoring to normal size.
        /// </summary>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keyboard.IsKeyDown(Key.LeftAlt) && Keyboard.IsKeyDown(Key.Enter)) || (Keyboard.IsKeyDown(Key.RightAlt) && Keyboard.IsKeyDown(Key.Enter)))
            {
                AdjustWindowSize();
            }
        }
        /// <summary>
        /// Manages the btnAddTask Click event.
        /// </summary>
        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            LoadControl(new InsertTodoView());
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            widget.SaveItems();
        }
    }
}
