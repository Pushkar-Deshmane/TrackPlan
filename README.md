# DiagonalWordApp - TrackPlan Technical Interview Solution

DiagonalWordApp is a simple .NET 8 MVC web application that allows users to input a word and display it diagonally on a second page. The word is shown both in normal and reversed diagonal formats using HTML table tags.

## Requirements
* .NET 8 SDK
* Git


## Setup Instructions:

1. Clone the Repository (https://github.com/Pushkar-Deshmane/TrackPlan)
3. Install .NET 8 SDK: Ensure you have the .NET 8 SDK installed. You can download and install it from the official .NET website. [**.NET 8 SDK**](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
4. Run the Application

## Usage
1. Enter a Word: On the home page, type a word into the input box.
2. Submit the Word: Click the "Go" button.
3. View the Result: The second page will display the word diagonally and in reverse diagonally.

![Screenshot of first screen]()


### Quote
* Id: int
* CustomerId: int (foreign key to Customer)
* CarModel: string
* CarYear: int
* Price: decimal
* Customer: Customer (Navigation Property)

![Screenshot of Quote Model](https://github.com/Pushkar-Deshmane/InsureCar/blob/master/InsureCar.Api/img/quote%20Model.PNG "Quote Model")


## Getting Started
### Prerequisites
1. [**.NET 8 SDK**](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
2. [**SQL Server**](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Installation
1. **Clone the repository:**
    ```
    git clone https://github.com/Pushkar-Deshmane/InsureCar.git
    cd InsureCar
    ```
2. **Restore dependencies:**

    `dotnet restore`
   
4. **Update database connection string:**

    Update the connection string in appsettings.json located in the InsureCar.Api project to point to your SQL Server instance.

6. **Run database migrations:**

   `dotnet ef migrations add InitialCreate --project InsureCar.Api`
   
   `dotnet ef database update --project InsureCar.Api`

   (This can also be done from visual studio instead of commanf prompt using Package Manager Console and EF migration commands)

7. **Run the application:**

    `dotnet run --project InsureCar.Api`

***Let's asuume the API will be running at https://localhost:44385. your port number could be different here***

## Using Swagger

Swagger is available for API documentation and testing. Open your browser and navigate to https://localhost:44385/swagger to view and test the endpoints.

## Testing with Postman

To test the API using Postman, follow these steps:

**1. Create a Customer:**

* URL: https://localhost:44385/api/customer
* Method: POST
* Body:
  ```
      {
          "firstName": "Pushkar",
          "lastName": "Deshmane",
          "dateOfBirth": "1980-01-01T00:00:00Z",
          "address": "123 Cork St"
      }
  ```

**2. Update a Customer:**

* URL: https://localhost:44385/api/customer/1
* Method: PUT
* Body:
  ```
      {
          "id": 1,
          "firstName": "Pushkar",
          "lastName": "Deshmane",
          "dateOfBirth": "1980-01-01T00:00:00Z",
          "address": "456 Cork main St"
      }
  ```

**3. Get Customers with Quotes Over a Certain Amount:**

* URL: https://localhost:44385/api/customer/quotes-over/1000
* Method: GET

**4. Create a Quote:**

* URL: https://localhost:44385/api/quote
* Method: POST
* Body:
  ```
      {
          "customerId": 1,
          "carModel": "BMW",
          "carYear": 2019,
          "price": 1500.00
      }
  ```
**5. Get Quotes by Car Model:**

* URL: https://localhost:44385/api/quote/car-model/BMW
* Method: GET

**6. Delete a Quote:**

* URL: https://localhost:44385/api/quote/1
* Method: DELETE

## Running Unit Tests

Unit tests are implemented using xUnit and Moq. To run the tests, use the following command:

`dotnet test`

## Possible Improvements

We can implement UnitOfWork in this .NET API Application to make it decoupled

## Resources Used

* [https://www.w3schools.com/cs/cs_interface.php](https://www.w3schools.com/cs/cs_interface.php)
* [https://try.stackoverflow.co/explore-teams?utm_source=adwords&utm_medium=ppc&utm_campaign=kb_teams_search_brand_emea-dach&_bt=657236278306&_bk=stack+overflow&_bm=p&_bn=g&gad_source=1&gclid=CjwKCAjw7s20BhBFEiwABVIMrdrlIgI9WvCXtGyRvt3BPxIitKRkTyhuT6qNaz3kKVRH9pY33ITZTRoCSqAQAvD_BwE](https://try.stackoverflow.co/explore-teams?utm_source=adwords&utm_medium=ppc&utm_campaign=kb_teams_search_brand_emea-dach&_bt=657236278306&_bk=stack+overflow&_bm=p&_bn=g&gad_source=1&gclid=CjwKCAjw7s20BhBFEiwABVIMrdrlIgI9WvCXtGyRvt3BPxIitKRkTyhuT6qNaz3kKVRH9pY33ITZTRoCSqAQAvD_BwE)
* [https://www.udemy.com/certificate/UC-c6422dad-f7d5-43e8-9c64-3103714dd2f1/](https://www.udemy.com/certificate/UC-c6422dad-f7d5-43e8-9c64-3103714dd2f1/)
     
