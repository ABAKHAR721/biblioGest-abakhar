// Ces using sont essentiels
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

// Ajoute ceux-ci si tu ne les as pas déjà :
using BiblioGest.Models;
using BiblioGest.Data;
using BiblioGest.Commands; // si tu as mis RelayCommand ici


public class LivreViewModel : BaseViewModel
{
    public ObservableCollection<Livre> Livres { get; set; }
    public Livre NewLivre { get; set; } = new Livre();
    public Livre SelectedLivre { get; set; }

    public ICommand AddLivreCommand { get; }
    public ICommand DeleteLivreCommand { get; }

    public LivreViewModel()
    {
        AddLivreCommand = new RelayCommand(_ => AjouterLivre());
        DeleteLivreCommand = new RelayCommand(_ => SupprimerLivre());
        LoadLivres();
    }

    private void LoadLivres()
    {
        using var db = new AppDbContext();
        Livres = new ObservableCollection<Livre>(db.Livres.ToList());
        OnPropertyChanged(nameof(Livres));
    }

    private void AjouterLivre()
    {
        if (string.IsNullOrWhiteSpace(NewLivre.ISBN)) return;

        using var db = new AppDbContext();
        db.Livres.Add(NewLivre);
        db.SaveChanges();
        Livres.Add(NewLivre);
        NewLivre = new Livre();
        OnPropertyChanged(nameof(NewLivre));
    }

    private void SupprimerLivre()
    {
        if (SelectedLivre == null) return;

        using var db = new AppDbContext();
        var livre = db.Livres.FirstOrDefault(l => l.ISBN == SelectedLivre.ISBN);
        if (livre != null)
        {
            db.Livres.Remove(livre);
            db.SaveChanges();
            Livres.Remove(SelectedLivre);
        }
    }
}
