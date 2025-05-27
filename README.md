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

🔐 Login with `Username` + `Password` (`admin/admin`)

📌 Screenshot:
![image](https://github.com/user-attachments/assets/28c68ead-36af-4917-a3a0-6a53a8351a2f)

---

### 2️⃣ Main Interface (Side Menu)

🎛️ Modern menu to access modules: Books, Members, Loans, Dashboard

📌 Screenshot:
📷 ![image](https://github.com/user-attachments/assets/46c17172-a598-49eb-a70f-1cc9801b969b)

---

### 3️⃣ Book Management Module

📘 Add, modify, delete, view books.
Dynamic input with DataGrid.

📌 Screenshot:
📷 ![image](https://github.com/user-attachments/assets/a705bfc0-54f7-4a5f-8cd1-04ed13340077)

---

### 4️⃣ Member Management Module

👤 Complete member management with a styled form + history

📌 Screenshot:
📷 ![image](https://github.com/user-attachments/assets/4fb4bf24-732d-425a-a399-a0b0b2819cb4)

---

### 5️⃣ Loan Management Module

📅 Select a book + member, add a loan, record a return, automatically detect delays.

📌 Screenshot:
📷 ![image](https://github.com/user-attachments/assets/cd75a586-785f-45a6-85e1b2011b3)

---

### 6️⃣ Administrative Dashboard

📊 Displays:
- 📘 Number of books
- 📅 Current loans
- ⏰ Delays
- 📈 Graphs via LiveCharts
- 🕒 List of the latest loans

📌 Screenshot:
📷 ![image](https://github.com/user-attachments/assets/09a29ce9-30c6-467b-8941-3acc9bf1bb8f)

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