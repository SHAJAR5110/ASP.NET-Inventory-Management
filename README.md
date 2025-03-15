

## **Product Inventory Management - ASP.NET Core MVC**  
A simple **Product Inventory Management** web application built with **ASP.NET Core MVC**. The application allows users to view a list of products, see product details, and simulate adding new products using in-memory data (arrays).  

🚀 **Deployed on Azure using Azure App Services**  

---

## **📌 Features**
✅ View a list of products  
✅ View detailed information for each product  
✅ Add new products (simulated, stored in memory)  
✅ Responsive UI using Bootstrap  
✅ Error handling with `ErrorViewModel`  
✅ Deployed to **Azure App Services**  

---

## **🛠️ Technologies Used**
- **ASP.NET Core MVC** (for building web application)  
- **C#** (for backend logic)  
- **Bootstrap** (for responsive UI)  
- **Azure App Services** (for deployment)  

---

## **📂 Project Structure**
```
ProductInventoryApp/
│-- Controllers/
│   ├── HomeController.cs
│   ├── ProductController.cs
│-- Models/
│   ├── Product.cs
│   ├── ErrorViewModel.cs
│-- Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   ├── Privacy.cshtml
│   ├── Product/
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _ViewImports.cshtml
│   │   ├── _ViewStart.cshtml
│   │   ├── Error.cshtml
│-- wwwroot/
│-- appsettings.json
│-- Program.cs
│-- Startup.cs
│-- ProductInventoryApp.csproj
│-- README.md
```

---

## **⚡ How to Run Locally**
1. **Clone the Repository**  
   ```sh
   git clone https://github.com/SHAJAR5110/ASP.NET-Inventory-Management.git
   cd ProductInventoryApp
   ```

2. **Run the Application**
   ```sh
   dotnet run
   ```

3. **Open in Browser**  
   Go to `http://localhost:5000` to view the app.

---

## **☁️ Deployment to Azure**
1. **Login to Azure CLI**  
   ```sh
   az login
   ```

2. **Deploy to Azure App Services**  
   ```sh
   dotnet publish -c Release
   az webapp up --name ProductInventoryApp --resource-group MyResourceGroup --runtime "DOTNETCORE|8.0"
   ```

---

## **📌 Screenshots**
### 🏠 Home Page  
![Home Page](https://via.placeholder.com/800x400?text=Home+Page)

### 📦 Product List  
![Product List](https://via.placeholder.com/800x400?text=Product+List)

---

## **📝 License**
This project is licensed under the **MIT License**.

---

## **💡 Contributors**
👤 **Your Name**  
🔗 GitHub: [Shajar Abbas](https://github.com/SHAJAR5110)  

---

