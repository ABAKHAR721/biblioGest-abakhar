using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using BiblioGest.Commands;

namespace BiblioGest.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(_ => Login());
        }

        private void Login()
        {
            if (Username == "admin" && Password == "admin")
            {
                // Authentification réussie
                Application.Current.MainWindow.Content = new BiblioGest.Views.MainAppView(); 
            }
            else
            {
                MessageBox.Show("Identifiants invalides !");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
