# SimpleLoginAndRegister

A C# Windows Forms application with PHP API backend for user authentication and registration.

## 📋 Overview

This project consists of a C# Windows Forms client application that communicates with a PHP API backend to handle user login and registration functionality. The application provides a simple and intuitive interface for user authentication.

## 🏗️ Architecture

- **Frontend**: C# Windows Forms (.NET Framework 4.8)
- **Backend**: PHP API with MySQL database
- **Authentication**: Password hashing using BCRYPT
- **Communication**: HTTP POST requests with JSON responses

## 🚀 Features

- **User Registration**: Create new user accounts with username and password
- **User Login**: Authenticate existing users
- **Secure Password Storage**: Passwords are hashed using BCRYPT
- **JSON API Communication**: RESTful API endpoints for authentication
- **Error Handling**: Comprehensive error handling for API responses
- **Modern UI**: Clean and responsive Windows Forms interface

## 📁 Project Structure

```
SimpleLoginAndRegister/
├── SimpleLoginAndRegister/          # C# Windows Forms Application
│   ├── Login.cs                     # Login form implementation
│   ├── Register.cs                  # Registration form implementation
│   ├── Program.cs                   # Application entry point
│   ├── apitest.cs                   # API testing utility
│   ├── SimpleLoginAndRegister.csproj # Project file
│   └── Properties/                  # Application properties
├── PHP API/                         # Backend API
│   ├── login.php                    # Login endpoint
│   ├── register.php                 # Registration endpoint
│   └── db.php                       # Database connection
├── SimpleLoginAndRegister.sln       # Solution file
└── README.md                        # This file
```

## 🛠️ Prerequisites

### For C# Application
- Visual Studio 2019 or later
- .NET Framework 4.8
- Newtonsoft.Json package (v13.0.3)

### For PHP API
- PHP 7.0 or later
- MySQL/MariaDB database
- Web server (Apache/Nginx)

## ⚙️ Installation & Setup

### 1. Database Setup

Create a MySQL database and table for users:

```sql
CREATE DATABASE hrpfmxnd_testapi;
USE hrpfmxnd_testapi;

CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(255) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
```

### 2. PHP API Configuration

1. Update the database connection in `PHP API/db.php`:
```php
$servername = "localhost";
$username = "your_username";
$password = "your_password";
$dbname = "your_database_name";
```

2. Deploy the PHP files to your web server
3. Ensure the API endpoints are accessible at:
   - `https://localhost/api/login.php`
   - `https://localhost/api/register.php`

### 3. C# Application Setup

1. Open `SimpleLoginAndRegister.sln` in Visual Studio
2. Restore NuGet packages:
   ```
   Install-Package Newtonsoft.Json -Version 13.0.3
   ```
3. Update API URLs in `Login.cs` and `Register.cs` if needed
4. Build and run the application

## 🔧 Configuration

### API Endpoints

The application is configured to use the following API endpoints:

- **Login**: `https://localhost/api/login.php`
- **Register**: `https://localhost/api/register.php`

To change these URLs, modify the `PostAsync` calls in:
- `Login.cs` (line 32)
- `Register.cs` (line 25)

## 📖 Usage

### Running the Application

1. Start the application by running `SimpleLoginAndRegister.exe`
2. The login form will appear as the main window
3. Click "Register" to create a new account
4. Use your credentials to log in

### API Testing

Use the `apitest.cs` utility to test API connectivity:

```csharp
// Test API endpoint
var apiUrl = "https://localhost/Login.php";
```

## 🔒 Security Features

- **Password Hashing**: All passwords are hashed using PHP's `password_hash()` with BCRYPT
- **SQL Injection Protection**: Basic protection through prepared statements (recommended to enhance)
- **JSON Response Validation**: Proper JSON parsing with error handling
- **Secure Communication**: HTTPS recommended for production use

## 🐛 Troubleshooting

### Common Issues

1. **API Connection Failed**
   - Verify PHP API is running
   - Check API URLs in the C# code
   - Ensure database connection is working

2. **JSON Parsing Errors**
   - Check API response format
   - Verify Content-Type headers in PHP
   - Review error handling in C# code

3. **Database Connection Issues**
   - Verify MySQL service is running
   - Check database credentials in `db.php`
   - Ensure database and table exist

### Debug Mode

Enable debug output by checking the console output for API responses and error messages.

## 📦 Dependencies

### C# Application
- **Newtonsoft.Json**: JSON parsing and serialization
- **System.Net.Http**: HTTP client for API communication
- **System.Windows.Forms**: Windows Forms UI framework

### PHP API
- **PHP**: Server-side scripting
- **MySQL**: Database management
- **mysqli**: MySQL database connection

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

## 🆘 Support

If you encounter any issues or have questions:

1. Check the troubleshooting section above
2. Review the code comments for implementation details
3. Create an issue in the GitHub repository

## 🔄 Version History

- **v1.0.0**: Initial release with basic login/register functionality
- Basic Windows Forms UI
- PHP API backend
- MySQL database integration

---

**Note**: This is a simple authentication system suitable for learning and development purposes. For production use, consider implementing additional security measures such as input validation, rate limiting, and proper session management.
