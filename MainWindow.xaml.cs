using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppTest
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    public class PersonModel
    {
        public ObservableCollection<Person> Persons;

        public PersonModel()
        {
            Persons = new ObservableCollection<Person>();
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Person> persons = new ObservableCollection<Person>();
            persons.Add(new Person("Alice", 23));
            persons.Add(new Person("Sasha", 13));
            persons.Add(new Person("Slice", 20));
            persons.Add(new Person("Katrin", 3));
            persons.Add(new Person("Malice", 203));
            PersonModel personModel = new PersonModel();
            personModel.Persons = persons;
            SpPersons.ItemsSource = persons;
        }
    }
}
