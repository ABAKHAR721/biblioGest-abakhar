using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using BiblioGest.Commands;
using BiblioGest.Views;

namespace BiblioGest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        // Commandes de navigation
        public ICommand ShowLivreViewCommand { get; }
        public ICommand ShowAdherentViewCommand { get; }
        public ICommand ShowEmpruntViewCommand { get; }
        public ICommand ShowDashboardViewCommand { get; }
        public ICommand ShowAdminDashboardCommand { get; }

        // Vue courante affichée
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
            // TEMP : test de base
            CurrentView = new TextBlock
            {
                Text = "Bienvenue 👋",
                FontSize = 24,
                Margin = new System.Windows.Thickness(20)
            };

            ShowLivreViewCommand = new RelayCommand(_ => ShowViewSafe(() => new LivreView()));
            ShowAdherentViewCommand = new RelayCommand(_ => ShowViewSafe(() => new AdherentView()));
            ShowEmpruntViewCommand = new RelayCommand(_ => ShowViewSafe(() => new EmpruntView()));
            ShowAdminDashboardCommand = new RelayCommand(_ => ShowViewSafe(() => new AdminDashboardView()));
        }


        // Méthode utilitaire pour éviter les crash si une vue plante
        private void ShowViewSafe(Func<object> createView)
        {
            try
            {
                CurrentView = createView();
            }
            catch (Exception ex)
            {
                CurrentView = new TextBlock
                {
                    Text = $"❌ Erreur de chargement : {ex.Message}",
                    Foreground = Brushes.Red,
                    Margin = new Thickness(20)
                };
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
