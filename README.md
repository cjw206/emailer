``` bash

#replace the smtp variables with actual smtp host values.

#restore packages
emailer/EmailService$ dotnet restore

#build project
emailer/EmailService$ dotnet build

#starts project on http://localhost:5000
emailer/EmailService$ dotnet run

#To run the web portion enter the following commands

#install packages
emailer/EmailerClient$ npm install

#runs on http://localhost:8080
emailer/EmailerClient$ npm run dev