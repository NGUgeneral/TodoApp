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

namespace OsaulenkoEgor_Diceus_Test.Assets
{
    public class Widgets
    {
        /// <summary>
        /// Widgets del combobox.
        /// </summary>
        /// <param x:Name="sender">Elemento que envía</param>
        /// <param x:Name="control">Información del elemento</param>
        public void Combobox_Watermark(object sender, FrameworkElement control)
        {
            ComboBox combobox = sender as ComboBox;
            TextBlock watermark = control.FindName(combobox.Name + "Watermark") as TextBlock;

            watermark.Visibility = combobox.SelectedItem == null ? Visibility.Visible : Visibility.Collapsed;
        }
        /// <summary>
        /// Widgets del textbox en focus.
        /// </summary>
        /// <param x:Name="sender">Elemento que envía</param>
        /// <param x:Name="control">Información del elemento</param>
        public void TextBox_GotFocus(object sender, FrameworkElement control)
        {
            TextBox textbox = sender as TextBox;
            
            TextBlock watermark = control.FindName(textbox.Name + "Watermark") as TextBlock;
            watermark.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Widgets del textbox al perder focus.
        /// </summary>
        /// <param x:Name="sender">Elemento que envía</param>
        /// <param x:Name="control">Información del elemento</param>
        public void TextBox_LostFocus(object sender, FrameworkElement control)
        {
            TextBox textbox = sender as TextBox;
            
            TextBlock watermark = control.FindName(textbox.Name + "Watermark") as TextBlock;
            watermark.Visibility = string.IsNullOrEmpty(textbox.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        public void LoadItems()
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    if(stream.Length > 0)
                    {
                        List<Todo> todolist = (List<Todo>)bin.Deserialize(stream);
                        InsertTodoViewModel _viewmodel = new InsertTodoViewModel();

                        foreach (Todo todo in todolist)
                        {
                            _viewmodel.SaveNewTodo(todo);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                string alert = ex.ToString();
            }
        }
        public void SaveItems()
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, AppSession.Instance.GetValue<List<Todo>>("todolist"));
                }
            }
            catch (IOException ex)
            {
                string alert = ex.ToString();
            }
        }
    }
}
