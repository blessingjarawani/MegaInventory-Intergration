# MegaInventory-Intergration
MegaInventory Intergration - Implemented in .Net Core 3.1 and AspCore 5.0

This is a dummy eshop application that allows us to add or update Warehouses, add clients, add products and create a verified sales order using MegaInventory API 
The project consists 3 layers which are Business logic, Data Access layer and Presentation Layer.

Presentation is the project named MegaInventory.Web which is a Asp core MVC- 
This is the user interface of the application that presents the application’s features and data to the user.
It consists views for our application which allows our users to enter data in respective forms.

DataAccess Layer  is the project named MegaInventory.DAL mainly is responsible for interacting with
our API endpoints to save and restore application data. We have the  MegaInventoryRepository class  thats where i implemented the application HttpClient 
and it has a httpBaseUrl constructor parameter you need to initialise it with the BaseUrl saved in our appsettings.json.

Business logic layer - project named MegaInventory.BLL  and MegaInventory This layer contains the business logic that drives the application’s core functionalities. 
it acts works in hand with the  MegaInventory.Services. Requests and Responses are handled in those 2 projects also  
 decisions, evaluations, and processing the data passing between the other two layers.
