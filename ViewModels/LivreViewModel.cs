using System.Collections.ObjectModel;
using System.Linq;

public class LivreViewModel : BaseViewModel
{
    public ObservableCollection<Livre> Livres { get; set; }

    public LivreViewModel()
    {
        using var db = new AppDbContext();
        Livres = new ObservableCollection<Livre>(db.Livres.ToList());
    }
}