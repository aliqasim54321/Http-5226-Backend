# Passion Project : Patient Registration and Management System

# Project Overview
This project is a comprehensive Content Management System (CMS) designed to facilitate the efficient management of patient records and appointments for healthcare providers. The system allows doctors to gain insights into the number of patients registered for appointments, manage patient information, and close registration when the required limit is reached. This CMS ensures a streamlined and organized approach to handling patient appointments, improving overall healthcare delivery and operational efficiency.

# Key Features
Patient Registration: Allows patients to register for appointments with doctors by providing their personal information
Patient Records Management: Maintains a comprehensive database of patient records, including personal details, blood group information.
Appointment Tracking: Enables doctors to monitor the number of patients registered for appointments in real-time.

# Features to explore in the Future:
Registration Limit Control: Allows doctors to set a limit on the number of patient registrations and close registration when the limit is reached.
Notification System: Sends notifications to patients and doctors regarding appointment confirmations, cancellations, and other important updates.

# Technologies Used
Backend: ASP.NET Web API, Entity Framework
Frontend: HTML, CSS, Bootstrap
Database: Microsoft SQL Server
Tools and Libraries: Visual Studio

# API Endpoints
List Patients: GET /api/PatientsData/ListPatients
Find Patient: GET /api/PatientsData/FindPatient/{id}
Add Patient: POST /api/PatientsData/AddPatient
Update Patient: POST /api/PatientsData/UpdatePatient/{id}
Delete Patient: POST /api/PatientsData/DeletePatient/{id}

# Retriving data from yhe command prompt
Get a List of Patient curl https://localhost:44324/api/Patientdata/listPatient

Get a Single Patient curl https://localhost:44324/api/Patientdata/findPatient/{id}

Add a new Patient (new Patient info is in Patient.json) curl -H "Content-Type:application/json" -d @Patient.json https://localhost:44324/api/Patientdata/addPatient

Delete an Patient curl -d "" https://localhost:44324/api/Patientdata/deletePatient/{id}

Update an Patient (existing Patient info including id must be included in Patient.json) curl -H "Content-Type:application/json" -d @Patient.json https://localhost:44324/api/Patientdata/updatePatient/{id}

#Challenges Faced During the Project
1)Managing foreign key constraints, particularly with the BloodGroupId in the Patients table.
2)Ensuring the consistency and integrity of patient records, especially when dealing with concurrent data access and modifications.
3)Efficiently handling errors and debugging issues during development and testing.

# License
This project is licensed under the MIT License. See the LICENSE file for details.

# Contact
For any questions or suggestions, feel free to open an issue or contact the project maintainer at aliqasimkhundmiri17@gmail.com.
