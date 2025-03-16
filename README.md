# Students Registry POM Project 🎓

This is an automated testing project built following the **Page Object Model (POM)** design pattern. The project automates the testing of a web application for registering students using **Selenium WebDriver** and **NUnit**.

---

## 📁 Project Structure

StudentsRegistryPOM/

Pages/
Page Object classes that represent the web pages and their elements.

AddStudentPage.cs – Represents the "Add Student" page.
ViewStudentsPage.cs – Represents the "View Students" page.
HomePage.cs – Represents the Home page.
BasePage.cs – Contains common functionality shared across all pages.
PagesTests/
NUnit test classes for testing the functionality of each page.

AddStudentsPageTests.cs – Tests for adding students.
ViewStudentsPageTests.cs – Tests for viewing students.
HomePageTests.cs – Tests for the Home page.
BaseTests.cs – Base class for common test setup and teardown.
SumNumApp/
Contains a basic calculator web app and its tests (with and without POM).

SumNumberPage.cs – Page Object for the calculator app.
SumNumTestsWithoutPOM.cs – Tests for the calculator app without using POM.


---

## ⚙️ Technologies Used

- **C#**
- **.NET**
- **Selenium WebDriver**
- **NUnit**
- **Page Object Model (POM)** design pattern

---

## 📝 Functionality Covered by the Tests

1. ✅ View the Home Page and validate the number of registered students.
2. ✅ Add a new student with valid data.
3. ✅ Attempt to add a student with invalid data (e.g., empty name or email) and check for an error message.
4. ✅ View the list of registered students and verify the added student appears in the list.

---

## 🚀 How to Run the Tests

### 1. Prerequisites
- Visual Studio 2022 or later
- .NET SDK (8.0)
- Selenium WebDriver
- NUnit framework

### 2. Steps
1. Clone the repository:
     git clone https://github.com/Veronika0601/WebDriverPOMDemo.git

