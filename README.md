# 📚 BiblioGest – Mini Project C# WPF

### 👨‍💻 Owner / Developed by:
- **ABAKHAR Abdessamad**

### 🎓 Supervised by:
- **Prof. Hassan ZILI**

---

## 🔧 Configure the Connection String

In the `AppDbContext.cs` file, replace the configuration with:

```csharp
options.UseNpgsql("Host=localhost;Port=5432;Database=biblio_db;Username=postgres;Password=YOUR_PASSWORD");
```

---

## ⚙️ Apply Migrations

From the NuGet Package Manager Console:

```powershell
Add-Migration Init
Update-Database
```

---

## ▶️ Launch the Project from Visual Studio

1.  Open the `BiblioGest.sln` solution.
2.  Select `MainWindow.xaml` as the startup window.
3.  Press **F5** to start the application 🚀

---

## 🧱 Project Structure

```bash
BiblioGest/
│
├── Models/               # Entities: Book, Member, Loan
├── Data/                 # AppDbContext
├── Views/                # WPF Graphical Interfaces
├── ViewModels/           # Business Logic (MVVM)
├── Commands/             # RelayCommand for buttons
└── MainWindow.xaml       # Application Entry Point
```

---

## 🖼️ Screenshots + Explanation

### 1️⃣ Login Screen

🔐 Login with `Username` + `Password` (`**abkhar**/**abkhar**`)

📌 Screenshot:
![WhatsApp Image 2025-05-28 at 00 39 23_bd03283e](https://github.com/user-attachments/assets/f1ffcfca-e0e4-467d-a0ab-738742742fb3)

---
### 2️⃣ Book Management Module

📘 Add, modify, delete, view books.
Dynamic input with DataGrid.

📌 Screenshot:
📷 ![WhatsApp Image 2025-05-28 at 00 39 50_eafe8482](https://github.com/user-attachments/assets/c48d73bb-e3b6-4314-b62a-3c1cbd74b89a)

---

### 3️⃣ Member Management Module

👤 Complete member management with a styled form + history

📌 Screenshot:
📷 ![WhatsApp Image 2025-05-28 at 00 40 00_4639330d](https://github.com/user-attachments/assets/5fa70e69-62dd-435a-837f-8ac6949c2ef2)


---

### 4️⃣ Loan Management Module

📅 Select a book + member, add a loan, record a return, automatically detect delays.

📌 Screenshot:
📷 ![WhatsApp Image 2025-05-28 at 00 40 12_8c034a75](https://github.com/user-attachments/assets/527c313e-cf28-4f13-921f-12b1a6b24eeb)


---

### 5️⃣ Administrative Dashboard

📊 Displays:
- 📘 Number of books
- 📅 Current loans
- ⏰ Delays
- 📈 Graphs via LiveCharts
- 🕒 List of the latest loans

📌 Screenshot:
📷 ![WhatsApp Image 2025-05-28 at 00 39 37_200038b6](https://github.com/user-attachments/assets/06d0aa10-e001-4a36-a239-003445048966)


---

## ✅ Implemented Features (Requirements Specification)

- [x] Login interface with authentication
- [x] Navigation via a modern side menu
- [x] Complete CRUD for Books, Members, Loans
- [x] Management of loan delays
- [x] Statistical and interactive dashboard
- [x] Clear, responsive, and modern design

---

## 📦 Recommended Test Data

```json
📘 Book:
{
  "ISBN": "9781234567890",
  "Title": "na3im aljahl",
  "Author": "ABAKHAR ABDESSAMAD"
}

👤 Member:
{
  "LastName": "ABAKHAR",
  "FirstName": "Abdessamad",
  "Email": "abdssamad.abkhar22@gmail.com"
}

📅 Loan:
{
  "BookISBN": "9781234567890",
  "MemberId": 1,
  "LoanDate": "Today"
}
```

---

## 📌 Author

- 👨‍💻 **ABAKHAR Abdessamad**

### 🎓 Supervised by:
- **Prof. Hassan ZILI**

📬 _I am available for any presentation or demonstration!_

---

## 🔚 Conclusion

BiblioGest is a complete and modern solution for library management 📚.
It fully meets the requirements specification.

### 🚀 Possibilities for Evolution:
- Excel Export/Import
- Multi-user authentication
- Mobile application (with .NET MAUI)
- Multi-criteria filters and smart search
