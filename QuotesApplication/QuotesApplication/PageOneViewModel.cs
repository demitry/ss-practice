using Xamarin.Forms;

namespace QuotesApplication
{
    public class PageOneViewModel : ContentPage
    {
        private string _loginUser;

        public string LoginUser
        {
            get { return _loginUser; }
            set { _loginUser = value; }
        }


        public PageOneViewModel(string username)
        {
            _loginUser = username;
        }
    }
}
