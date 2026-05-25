# Accounnt Freeze Engine System Analysis 


- [Accounnt Freeze Engine System Analysis](#accounnt-freeze-engine-system-analysis)
  - [Reasoning](#reasoning)
  - [System Architecture](#system-architecture)
    - [Database](#database)
    - [Architecture](#architecture)
    - [C#](#c)
    - [Git \& GitHub](#git--github)

## Reasoning
For this project, the communication between teams is almost impossible, due to the lack of team management and project management resources, and the absence of team/project managers, so we have came to the conclusion that we shall improvise, by:

1. implementing our own "shared" assets, such as the **Database**, and fake/imaginary other parts of the system for testing purposes.
2. implementing our own **software architecture** and **design pattern**

## System Architecture

### Database
MySQL is a reliable and widely used relational database management system that helps store, organize, and manage application data efficiently. We used MySQL in our system because it provides fast performance, strong security, scalability, and easy data handling.

### Architecture
N-tier architecture is a software design approach that separates an application into multiple tiers, such as business logic and data access, to keep the system organized and maintainable. We used this architecture in our app to make **collaboration** easier with other teams working on different parts of the system, while allowing our team to focus only on the **backend functionality** without being responsible for the front-end implementation.

### C#
C# is a modern and object-oriented programming language commonly used for developing reliable and scalable applications. We used C# in our project because it was the default language for the course, while also benefiting from its strong integration with the .NET framework, clean syntax, good performance, and extensive support for building structured backend systems and database-driven applications.

### Git & GitHub
Git and GitHub are essential tools for version control and collaborative software development. We used them in our project to manage code changes efficiently, track project progress, and make collaboration easier between team members by allowing everyone to work on different parts of the system without conflicts while maintaining a centralized and organized code repository.