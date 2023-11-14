using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PageNavTestApp.ViewModels
{
    public class CommandExampleVM
    {
        public ICommand CommandClick =>
            new Command(ExecuteAlert);

        private void ExecuteAlert(object obj)
        {
            App.Current.MainPage.DisplayAlert("Hi", "Techpro Compsoft", "Ok");
        }

    }
}
