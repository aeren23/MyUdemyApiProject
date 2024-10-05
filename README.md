# Hotelier-Backend Project


## Project Description
This Project is a full stack web side project that developed for hotel reservation transactions.Developed by using Layered Architecture and repository design pattern. 


## Techs
- **Backend:** ASP.NET Core, C#, Entity Framework
- **Frontend:** HTML, CSS, JS, Bootstrap
- **Database:** SQL Server
- **API:** RESTful API


## Project Architecture

- **Layers:**
  - **Presentation Layer (UI)**
  - **API**
  - **Entity Layer** 
  - **Business Logic Layer (BLL)** 
  - **Data Access Layer (DAL)**


## Setup Directions

### Requirements:
- .NET SDK
-  NPM
- SQL Server

### Steps:
1. Clone the repository:
   ```bash
   git clone https://github.com/aeren23/MyUdemyApiProject
   ```

2. Run Backend:
   ```bash
   cd backend
   dotnet restore
   dotnet run
   ```

3. Run Frontend:
   ```bash
   cd frontend
   npm install
   npm start
   ```

## 7. **API Documentation**
API Documentation

```markdown
## API Documentation

### Endpoints:
- **GET** /api/booking
  - Description: Gets bookings.
  - Example Response:
    ```json
    [
      {
    "bookingID": 1,
    "name": "Mr. No body",
    "mail": "blabla@gmail.com",
    "checkin": "01/01/2024",
    "checkOut": "01/01/2024",
    "adultCount": "1",
    "childCount": "1",
    "roomCount": "1",
    "specialRequest": "yok",
    "description": "string",
    "status": "Onaylandı",
    "city": "Birmingham",
    "country": "England"
      }
    ]
    ```

     

