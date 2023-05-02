using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace QuotesApplication
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { get; set; }

        private string _username;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string UserName
        {
            get { return _username; }
            set 
            { 
                _username = value;
                OnPropertyChanged(nameof(UserName));
            }
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
