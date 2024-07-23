# EmailSample
A sample .NET 6 application that sends an email

## Steps
1. Clone the repository
2. Type `dotnet restore` on the terminal (if you have .NET 6 SDK installed)
3. Create a **.env** file (due to the .gitignore, it won't be given as untracked)
4. Put the following variables in the file:
```
FROM_EMAIL="from who the email will be sent"
PASSWORD="password of the sender"
TO_EMAIL="to who the email will be sent"
```