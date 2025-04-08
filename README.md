# 🛡️ User-Friendly System Call Interface for Enhanced Security

A Windows Forms application built in C# that allows users to interact with core system functions like **CreateFile**, **ReadFile**, and **WriteFile** — with added **authentication**, **logging**, and a clean **GUI interface** for better usability and security.

---

## 🚀 Features

- 🔐 **Login Authentication**
- 📁 **Create, Write, and Read Files**
- 📄 **Explanation of Each System Call**
- 🧾 **Real-Time System Call Logging**
- 🎨 **Modern User Interface with C# Windows Forms**

---

## 📷 Screenshots


| Login Screen | System Interface |
|--------------|------------------|
| ![login](https://github.com/user-attachments/assets/f83074ce-6ed3-4d76-8216-5dbb9b898a27) | ![Interface](https://github.com/user-attachments/assets/43ce5bdf-3522-46ce-a349-470358f2b37f) |

---


## 🧠 System Calls Covered

| System Call | Description |
|-------------|-------------|
| `CreateFile` | Creates a new file at `C:\Users\Public\testfile.txt` if it doesn’t exist |
| `WriteFile`  | Writes user input to the file (overwrites existing content) |
| `ReadFile`   | Reads content from the file and displays it in the interface |

---

## 🔐 Login Details

- **Username:** `admin`
- **Password:** `password123`

> You can modify these in `LoginForm.cs`.

---

## 📜 System Call Logging

Every time a system call is triggered, the app logs the action to:

```
C:\Users\Public\systemcall_log.txt
```

Example log entry:
```
2025-04-08 18:20:34 | User: admin | Call: WriteFile: testfile.txt
```

---

## 📁 Project Structure

```
SystemCallInterface/
│
├── Form1.cs               # Main system call interface
├── LoginForm.cs           # Login form with validation
├── Session.cs             # Stores logged-in user info
├── Program.cs             # Entry point of the application
├── Form1.Designer.cs      # Modern UI for main form
├── LoginForm.Designer.cs  # Modern UI for login
├── README.md              # 📄 You're reading it!
└── screenshots/           # Optional screenshots for GitHub preview
```

---

## 🛠️ Tech Stack

- 🖥️ C# Windows Forms (.NET Framework)
- 📚 System.IO for file handling
- 👤 Session-based user tracking
- ✨ WinForms UI Design

---

## ✍️ Author

**Ravi Kumar**  
🎓 B.Tech CSE, Lovely Professional University  
📧 [ravikumartekkali2006@gmail.com](mailto:ravikumartekkali2006@gmail.com)  
🌐 [LinkedIn](https://www.linkedin.com/in/ravi-kumar-tekkali)

---

## 💡 Future Ideas

- 📊 Dashboard for admin activity
- 📌 File selection via file dialogs
- 🧾 Detailed logging viewer
- 🔐 Role-based authentication

---

## ⭐️ Support

If you like this project, please consider giving it a ⭐️ on GitHub!  
Have ideas or feedback? Create an issue or reach out!

---
