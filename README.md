# Cubic .Net Authentication and Authorization Task

This is a simple .Net Web API that provides two basic GET and one POST endpoints

## Requirements

- .NET 8.0 SDK.
- Postman.

## Run the API

1- **Clone the repository**
- run git clone https://github.com/MahmodSamir/CubicTask.git
- Start the application and it should be accessible at your localhost port

2- **Postman Tests**
- Kindly, trying the following link to access requests immediately (check on port and application must be running)
     https://www.postman.com/bold-water-676631/workspace/cubictask/collection/23347925-0c796c4d-3a69-4d27-99d2-2a26ff56f470?action=share&creator=23347925

  *OR*

- Create a new GET request and set the URL to https://localhost:YOUR_PORT/api/Test/public
    to access public data without auth and JWT, you should receive a response string message.
  
- Create a new POST request and set the URL to https://localhost:YOUR_PORT/api/Authentication/login  
    username = "CubicUser", and password = "CubicPassword" to get JWT token string, copy it.
- then create a new GET request and set the URL to https://localhost:YOUR_PORT/api/Test/secure
    click on Authorization tab and in the Auth Type dropdownList choose Bearer Token and paste the copied token into Token Textfield.
    you should recieve a response string message if authorized otherwise it will give you a 401 Unauthorized status.

## Troubleshooting
- *If it keeps giving you Unauthorized status incorrectly*
  make sure you have Microsoft.IdentityModel.JsonWebToken NuGet package installed instead of System.IdentityModel.JWT.

  
## Here are sinppets of the Code and Postman tests to illustrate:

- appesettings.json file include JWT-generated-Key, Issuer, and Audience.
  ![appsettings.json](https://github.com/MahmodSamir/CubicTask/assets/63668000/1828afa5-7c36-40f9-b5a1-dc11dd9a6e1e)
  
- AuthenticationController with a constructor for IConfigration to access JWT in appsettings.json, and LoginModel class to mock a username and password, Eventually Create JWT token with descritpors and HS256 algorithm into string to be returned.
![AuthenticationController](https://github.com/MahmodSamir/CubicTask/assets/63668000/1d4eb08d-4711-425a-8cdd-1e8469ff2787)


- Program.cs with AddAuthentication Service to validate JWT token.
![Program.cs](https://github.com/MahmodSamir/CubicTask/assets/63668000/d0cea449-54a2-4227-a233-e965d75559e7)

- TestController with GET GetSecureData endpoint decorated with Authorized attribute to secure it and Public GET GetPublicData endpoint.
![TestController](https://github.com/MahmodSamir/CubicTask/assets/63668000/1c3f9b73-c561-4a98-914e-ddad292d9843)


- *Postman GET public data request.*
![GET public](https://github.com/MahmodSamir/CubicTask/assets/63668000/e5757134-bcbf-4ef9-ab39-3c0730a71c9e)

- *Postman POST login request.*
![POST login](https://github.com/MahmodSamir/CubicTask/assets/63668000/8b028e15-2a44-48fc-997f-91eb87bdd302)

- *Postman GET secured data request authorized.*
![GET secured auth](https://github.com/MahmodSamir/CubicTask/assets/63668000/8bf24b6a-6533-45ca-a9e7-27ec6ae87d2e)

- *Postman GET secured data request Unauthorized.*
![GET secured UnAuth](https://github.com/MahmodSamir/CubicTask/assets/63668000/9a29d6da-a353-468f-ba59-80cd3a498dc4)

- *Swagger endpoints.*
![Swagger](https://github.com/MahmodSamir/CubicTask/assets/63668000/2eb868f8-ec5a-4432-a455-38f858190c29)
