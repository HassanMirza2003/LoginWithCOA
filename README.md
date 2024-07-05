# LoginWithCOA
This repository contains a simple ASP.NET Web Forms application for user login with role-based redirection. The application demonstrates the use of ADO.NET for database connectivity, session management, and basic role-based access control.

**Features**
User login with email and password.
Role-based redirection to different pages (Admin, Employee, Client).
Session management for maintaining user state.
Basic error handling and response messages.

**Technologies Used**
ASP.NET Web Forms
C#
ADO.NET
SQL Server

**Project Structure**
AppProps: Contains classes representing the application properties, such as User.
DataAccessLayer: Contains Data Access Layer classes for interacting with the database using ADO.NET.
BusinessLogicLayer: Contains Business Logic Layer classes for handling business logic.
LoginWithCOA: Contains the web forms and controls for the login and role-based redirection.

**Usage**
**User Login**
Navigate to the login page (Logind.aspx).
Enter the email and password of a user.
Click the "Login" button.

**Role-Based Redirection**
Based on the user's role (AccessLevel), the application redirects to the appropriate page:
Admin: Redirects to Admin.aspx
Employee: Redirects to Employee.aspx
Client: Redirects to Client.aspx
If the user is not found or the credentials are incorrect, an error message is displayed.

**Example Roles**
Admin: AccessLevel 1
Employee: AccessLevel 2
Client: AccessLevel 3
**Contributing**
Contributions are welcome! Please fork the repository and create a pull request with your changes. Ensure that your code follows the existing style and conventions.

**License**
This project is licensed under the MIT License. See the LICENSE file for more details.








