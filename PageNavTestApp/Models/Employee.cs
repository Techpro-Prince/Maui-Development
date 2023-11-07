using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavTestApp.Models
{
    public class Employee:INotifyPropertyChanged
    {
        
        private int id;

        public int Id
        {
            get => id; 
            set { id = value;
                OnPropertyChanged(nameof(Id));
                }
        }

        private string name;

        public string Name
        {
            get => name; 
            set { name = value;
                OnPropertyChanged(nameof(Name));

            }
        }

        private int age;

        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged(nameof(Age));
            }
        }


        private int salary;

        public int Salary
        {
            get => salary;
            set
            {
                salary = value;
                OnPropertyChanged(nameof(Salary));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name)=> PropertyChanged?
            .Invoke(this, new PropertyChangedEventArgs(name));
    }
}
