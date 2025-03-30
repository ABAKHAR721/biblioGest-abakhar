using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BiblioGest.Commands;
using BiblioGest.Views;

namespace BiblioGest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand ShowLivreViewCommand { get; }
        public ICommand ShowAdherentViewCommand { get; }
        public ICommand ShowEmpruntViewCommand { get; }
        public ICommand ShowDashboardViewCommand { get; }
        public ICommand ShowAdminDashboardCommand { get; }
        private void SetAdminDashboardView() => CurrentView = new AdminDashboardView();

        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            ShowAdminDashboardCommand = new RelayCommand(_ => SetAdminDashboardView());
            CurrentView = new AdminDashboardView();
            ShowLivreViewCommand = new RelayCommand(_ => CurrentView = new LivreView());
            ShowAdherentViewCommand = new RelayCommand(_ => CurrentView = new AdherentView());
            ShowEmpruntViewCommand = new RelayCommand(_ => CurrentView = new EmpruntView());
            ShowDashboardViewCommand = new RelayCommand(_ => CurrentView = null);


            CurrentView = new LivreView(); 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
      
      


    }
}
