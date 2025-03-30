# 📚 BiblioGest – Mini Projet C# WPF

### 👨‍💻 Réalisé par :
- **Mohamed BARBYCH**
- **Mouaad ELHANSALI**

---

## 🔧 Configurer la chaîne de connexion

Dans le fichier `AppDbContext.cs`, remplace la configuration par :

```csharp
options.UseNpgsql("Host=localhost;Port=5432;Database=biblio_db;Username=postgres;Password=TON_MOT_DE_PASSE");
```

---

## ⚙️ Appliquer les migrations

Depuis la console du gestionnaire de packages NuGet :

```powershell
Add-Migration Init
Update-Database
```

---

## ▶️ Lancer le projet depuis Visual Studio

1. Ouvrir la solution `BiblioGest.sln`
2. Sélectionner `MainWindow.xaml` comme fenêtre de démarrage
3. Appuyer sur **F5** pour démarrer l'application 🚀

---

## 🧱 Structure du projet

```bash
BiblioGest/
│
├── Models/               # Entités : Livre, Adherent, Emprunt
├── Data/                 # AppDbContext
├── Views/                # Interfaces graphiques WPF
├── ViewModels/           # Logique métier (MVVM)
├── Commands/             # RelayCommand pour les boutons
└── MainWindow.xaml       # Point d’entrée de l’application
```

---

## 🖼️ Captures d’écran + Explication

### 1️⃣ Écran de Connexion

🔐 Login avec `Username` + `Mot de passe` (`admin/admin`)

📌 Capture :  
📷 _[Insérer ici la capture de l'écran de login]_

---

### 2️⃣ Interface principale (Menu latéral)

🎛️ Menu moderne pour accéder aux modules : Livres, Adhérents, Emprunts, Dashboard

📌 Capture :  
📷 _[Insérer ici la capture de la page principale]_

---

### 3️⃣ Module de Gestion des Livres

📘 Ajouter, modifier, supprimer, consulter les livres.  
Saisie dynamique avec DataGrid.

📌 Capture :  
📷 _[Insérer ici la capture de l'écran Livres]_

---

### 4️⃣ Module de Gestion des Adhérents

👤 Gestion complète des adhérents avec formulaire stylé + historique

📌 Capture :  
📷 _[Insérer ici la capture de l'écran Adhérents]_

---

### 5️⃣ Module de Gestion des Emprunts

📅 Sélectionner un livre + adhérent, ajouter un emprunt, enregistrer un retour, détecter automatiquement les retards.

📌 Capture :  
📷 _[Insérer ici la capture de l'écran Emprunts]_

---

### 6️⃣ Dashboard Administratif

📊 Affiche :
- 📘 Nombre de livres
- 📅 Emprunts en cours
- ⏰ Retards
- 📈 Graphiques via LiveCharts
- 🕒 Liste des derniers emprunts

📌 Capture :  
📷 _[Insérer ici la capture du Dashboard]_

---

## ✅ Fonctionnalités réalisées (Cahier des charges)

- [x] Interface de connexion avec authentification
- [x] Navigation via menu latéral moderne
- [x] CRUD complet pour Livres, Adhérents, Emprunts
- [x] Gestion des retards d’emprunts
- [x] Dashboard statistique et interactif
- [x] Design clair, responsive et moderne

---

## 📦 Données de test recommandées

```json
📘 Livre : 
{
  "ISBN": "9781234567890",
  "Titre": "Le Petit Prince",
  "Auteur": "Saint-Exupéry"
}

👤 Adhérent :
{
  "Nom": "Alaoui",
  "Prénom": "Samira",
  "Email": "samira.alaoui@gmail.com"
}

📅 Emprunt :
{
  "Livre": "9781234567890",
  "AdherentId": 1,
  "DateEmprunt": "Aujourd'hui"
}
```

---

## 📌 Auteurs

- 👨‍💻 **Mohamed BARBYCH**
- 👨‍💻 **Mouaad ELHANSALI**

📬 _Nous restons disponibles pour toute présentation ou démonstration !_

---

## 🔚 Conclusion

BiblioGest est une solution complète et moderne pour la gestion d’une bibliothèque 📚.  
Elle répond totalement aux exigences du cahier de charges.

### 🚀 Possibilités d’évolution :
- Export/Import Excel
- Authentification multi-utilisateurs
- Application mobile (avec .NET MAUI)
- Filtres multicritères et recherche intelligente

🙏 Merci à notre professeur pour l’encadrement pédagogique de ce projet.

