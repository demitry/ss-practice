using System.Windows.Input;
using Xamarin.Forms;

namespace QuotesApplication
{
    public class MainViewModel
    {
        public ICommand LoginCommand { get; set; }

        private string _username;

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }


        public MainViewModel() 
        {
            LoginCommand = new Command(Login);            
        }

        private void Login()
        {
            App.Current.MainPage.DisplayAlert("Hi", _username, "Cancel");
        }
    }
}
