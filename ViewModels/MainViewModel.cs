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
            ShowLivreViewCommand = new RelayCommand(o => CurrentView = new LivreView());
            ShowAdherentViewCommand = new RelayCommand(o => CurrentView = null); // à remplacer par une vraie vue
            ShowEmpruntViewCommand = new RelayCommand(o => CurrentView = null);
            ShowDashboardViewCommand = new RelayCommand(o => CurrentView = null);

            CurrentView = new LivreView();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
