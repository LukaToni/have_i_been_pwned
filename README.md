# Have I been pwned

The purpose of the program is to build a system, that acts as a “smart cache” for breached e-mail
addresses. As an example, please follow the link below for an example:
https://haveibeenpwned.com/.

Architecture / Design
- It follows good practices as suggested by [Microsoft Orleans](https://dotnet.github.io/orleans/Documentation/index.html).
- Application is started via Console.

Technologies in use:
- OpenAPI (e.g. [Swagger / OpenAPI](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-3.1)) 
- [Azure Storage Emulator](https://docs.microsoft.com/en-us/azure/storage/common/storage-useemulator) 

#### Service
+ Acts as Distributed Cache (simulation)
+ One grain per Domain
    + Grain with domain id “geneplanet.com” contains list of all breached emails per domain
    + Provides ability to add and query against breached e-mails
    + State is stored to Azure Blob Storage on every 5th request
+ One grain per Top Level Domain
    + Grain with domain id “.com” contains list of all breached emails per top level domain
    + Provides ability to query against breached e-mails

#### API
+ Use WebAPI2
+ Operation
    + Provides ability to add a new email to the list of breached emails
    + Provides ability to check if provided email is already present in breached emails
+ Provides ability to remove the email from breached emails
+ Statistics
    + Provides ability to fetch number of all breached emails per domain
    + Provides ability to fetch number of all breached emails per top-level domain

#### Tests

+ Unit tests (code coverage at least at 40%)
+ Integration tests

## Quick Start:

Quick start options:

+ [Download from Github](https://github.com/LukaToni/have_i_been_pwned/archive/master.zip).
+ Clone the repo: `git clone https://github.com/LukaToni/have_i_been_pwned.git`.

