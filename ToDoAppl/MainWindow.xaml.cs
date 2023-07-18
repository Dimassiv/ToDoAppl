using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ToDoAppl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // string[] tasks = new string[3];
        ObservableCollection<Task> taskList = new ObservableCollection<Task>(); 
        public MainWindow()
        {
            InitializeComponent();

            //Task t1= new Task();    
            //t1.Name = "Купити молоко";
            //t1.IsCompleted= false;
            //t1.Description = "У Сільпо пастеризоване";

            //Task t2 = new Task();
            //t2.Name = "Вивчити С#";
            //t2.IsCompleted = false;
            //t2.Description = "по відео урокам Дмитра";

            //Task t3 = new Task();
            //t3.Name = "Створити резюме";
            //t3.IsCompleted = false;
            //t3.Description = "Для пошуку роботи";

            //taskList.Add(t1);
            //taskList.Add(t2);
            //taskList.Add(t3);


            ToDoListBox.ItemsSource = taskList;   
            ToDoListBox.DisplayMemberPath = "Name"; 
        }

       
        private void ToDoListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Task selected = ToDoListBox.SelectedItem as Task;
            if (selected != null) 
            { MessageBox.Show(selected.Description); }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NewTaskWindow window = new NewTaskWindow();
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            if (window.ShowDialog() == true) 
            {
                Task newTask = window.Result;
                taskList.Add(newTask);
            } 
                
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int index = ToDoListBox.SelectedIndex;
            if(index != -1)
            {
                taskList.RemoveAt(index);   
            }
        }

        private void CompleteButton_Click(object sender, RoutedEventArgs e)
        {
            int index = ToDoListBox.SelectedIndex;
            if (index != -1)
            {
                taskList[index].IsCompleted = true;
            }
        }

        private void AllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ToDoListBox.ItemsSource= taskList;  
        }

        private void NotCompletedRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Task> filtered = new ObservableCollection<Task>();
            for (int i = 0; i < taskList.Count; i++)
            {
                Task current = taskList[i];
                if (current.IsCompleted == false) { filtered.Add(current); }
            }
            ToDoListBox.ItemsSource = filtered;
        }

        private void CompletedRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Task> filtered = new ObservableCollection<Task>();
            for (int i = 0; i < taskList.Count; i++)
            {
                Task current = taskList[i];
                if (current.IsCompleted == true) { filtered.Add(current); }
            }
            ToDoListBox.ItemsSource = filtered;
        }

        string fileName = "data.bin";
        private void Window_Closed(object sender, EventArgs e)
        {
        BinaryFormatter formatter = new BinaryFormatter();
            Stream file = File.OpenWrite(fileName);
            formatter.Serialize(file, taskList);
            file.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream file = File.OpenRead(fileName);  
                taskList = formatter.Deserialize(file) as ObservableCollection<Task>;
                file.Close();   
                ToDoListBox.ItemsSource = taskList;
            }
             
        }
    }
}
