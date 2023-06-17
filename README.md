# Student Management System

Student Management System created using C# in Visual Studio for a institute called __Skills International__ (This is not an actual institute, just assume there is a one 😉). In this student management system, you need to log in first. There has an admin account already implemented. If you want an another account, you can use sign up. Read the instructions carefully while you signing up beacauce if you have to reset the password, the system will ask you some information to do that.

- Username: `Admin`
- Password: `Skills@123`

You can register a new student, update an already existing student, delete a student.

___NOTE: Usually a student management system should not delete a student because old student details are also very important. In such a case the system should mark that student as an old or inactive or leaved student instead of deleting the student and a student ID of an old student can't give to a new student. But it happens here in this system because this is just a demo project.___

## Database

- You need to install both [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) and [Microsoft SQL Server Management Studio](https://aka.ms/ssmsfullsetup)
- Then copy the database files __(Student.mdf and Student_log.ldf)__ in `Database` folder to `MSSQL\DATA` folder.
- Usually in `C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA`. Find it according to your pc and the version.
- Now open __SQL Server Management Studio__ and connect.
- Expand your server and right-click on `databases`.
- Then click on `Attach`.<br><br>![attach](https://raw.githubusercontent.com/dropcreations/Student-Management-System/main/Assets/databases_attach.png)
- Now select `Add`.<br><br>![add](https://raw.githubusercontent.com/dropcreations/Student-Management-System/main/Assets/databases_attach_add.png)
- Select `Student.mdf` and click `OK`<br><br>![mdf](https://raw.githubusercontent.com/dropcreations/Student-Management-System/main/Assets/databases_attach_mdf.png)

## Visual Studio

- Open `StudentManagementSystem.sln` in __Visual Studio__.
- Now open __Server Explorer__ to connect database.
- Right-click on `Data Connections` and click `Add Connection...`
- Then type your server name and select `Student` database.
- After adding database, right-click on the added database and get `Properties`.
- In properties, get `Connection String` and paste it into the `ConnectionString` variable in `LoginUI.cs` and `RegistrationUI.cs`

## User Interface

- Loading UI<br><br>![LoadingUI](https://raw.githubusercontent.com/dropcreations/Student-Management-System/main/Assets/LoadingUI.gif)

- Signin UI<br><br>![SignIn](https://raw.githubusercontent.com/dropcreations/Student-Management-System/main/Assets/SignInUI.png)

- SignUp UI<br><br>![SignUp](https://raw.githubusercontent.com/dropcreations/Student-Management-System/main/Assets/SignUpUI.png)

- NIC for Security UI<br><br>![NICReq](https://raw.githubusercontent.com/dropcreations/Student-Management-System/main/Assets/ReqNIC.png)

- Registration UI<br><br>![Registration](https://raw.githubusercontent.com/dropcreations/Student-Management-System/main/Assets/RegisterUI.png)
