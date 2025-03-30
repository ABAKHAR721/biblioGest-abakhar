using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using BiblioGest.Models;
using BiblioGest.Data;

namespace BiblioGest.ViewModels
{
    public class AdminDashboardViewModel : INotifyPropertyChanged
    {
        public int TotalLivres { get; set; } = 50;
        public int EmpruntsEnCours { get; set; } = 10;
        public int Retards { get; set; } = 2;

        public ObservableCollection<Emprunt> DerniersEmprunts { get; set; }

        public AdminDashboardViewModel()
        {
            DerniersEmprunts = new ObservableCollection<Emprunt>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}
