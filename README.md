# ExpenseBook – Angular + ASP.NET Core

A scalable Expense Book / Cashbook application inspired by cashbook.in.  
Built for learning full-stack development using **Angular**, **ASP.NET Core Web API**, and **Azure**.

---

## 🚀 Features (Planned)
- Add, edit, delete expenses
- Daily, weekly, monthly reports
- Categories (Food, Travel, etc.)
- User accounts & authentication
- Cloud deployment on Azure
- Mobile-friendly UI
- Export to Excel / PDF
- Dark mode (future)

---

## 🛠️ Tech Stack

### **Frontend**
- Angular 17+
- Angular Material / Tailwind CSS

### **Backend**
- ASP.NET Core 8/9 Web API
- Entity Framework Core
- SQL Server / Azure SQL

### **Infrastructure**
- Azure App Service
- Azure SQL Database
- GitHub Actions CI/CD
- Docker (optional)

---

## 📁 Project Structure

expensebook/
- ├── backend/ # .NET API
- ├── frontend/ # Angular UI
- ├── docs/ # Architecture, ER diagrams, notes
- ├── infra/ # Azure deployment configs
- └── README.md
---

## 🧪 Setup Instructions

### 1. Clone the repo
```bash
git clone https://github.com/<your-username>/expensebook.git
cd expensebook
```

### 2. Setup Backend (ASP.NET Core)
```bash
cd backend
dotnet restore
dotnet run
