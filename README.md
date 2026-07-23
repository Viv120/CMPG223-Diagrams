# NWU Second-Hand Book Exchange System

## Overview
This repository contains the NWU Second-Hand Book Exchange System, developed as part of my BSc Information Technology coursework. The system provides a platform for students to donate, request, and exchange second-hand books across NWU campuses. It includes functionality for administrators, donors, and applicants, with a structured database backend and user-friendly Windows application interface.

## Features

## Administrator
* Secure login
* Maintain books, donors, and applicants
* Approve book donation and request transactions
* Generate reports:
  * Total books donated in a specified period
  * Total books issued in a specified period

## Applicants (Students)
* Register and create login credentials
* Update personal information
* Request to receive books
* View issued books history

## Donors
* Register and create login credentials
* Update donor information
* Donate books with details (title, author, edition, condition, year published)
* Track donation history

## Technologies Used
* C# (Windows Forms)
* MySQL Database
* SQL Queries for CRUD operations
* Windows 10 GUI for user interaction

## Project Structure

```text
NWU-Book-Exchange/
│
├── NWU_Book_System.pdf      # User manual & documentation
├── /database                # SQL scripts for schema & tables
├── /forms                   # Windows Forms (Applicants, Donors, Admin)
├── /reports                 # Report generation modules
└── README.md
```

## Running the Project
## Requirements
* # Hardware:
  Standard PC running Windows 10
  
* # Software:
 ** MySQL Server
 ** Visual Studio with C# support
 ** .NET Framework

## Installation
1. Clone the repository:
```bash
git clone https://github.com/Viv120/CMPG223-Diagrams.git
```
2. Import the SQL scripts from /database into MySQL to create tables.

3. Open the solution in Visual Studio.
4. Build and run the application.

## Future Improvements
* Add web-based interface for remote access
* Implement email notifications for book requests and donations
* Enhance reporting with data visualization
* Add role-based access control for improved security

## Author

**Vivicia Cathryn Freemantle**
Group Project - NWU
* GitHub: https://github.com/Viv120  
* LinkedIn: https://www.linkedin.com/in/vivicia-freemantle-6491b6333/

