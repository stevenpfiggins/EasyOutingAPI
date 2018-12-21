# SIS-WebApi

## Architecture
This project uses N-Tier architecture to encapsulate structural concerns of the application into assemblies per concern.
Projects with the ".DataContract" suffix contain only DataContracts and Interfaces. The corresponding similarly named project implements the contract project.

#### Presentation Layer
Composes all layers together. You will need a Dependency Injection framework.
1) SIS.API
    1) Contains HTTP logic and routing
    1) Maps API data contracts to and from business data contracts and calls business layer Managers 
  
1) SIS.API.DataContract
    1) Contains request and response data contracts suffixed with "Request/Response"
  
1) SIS.API.Tests

#### Business Layer
The largest and most volatile layer. Has no knowledge of the Presentation Layer, but depends on Resource and Utility Layers.
1) SIS.Business.DataContract
    1) Contains Business objects suffixed with "DTO" (Domain Transfer Objects)
    2) Contains Interfaces for Managers & Engines to be suffixed with "Manager" or "Engine".
1) SIS.Business
    1) Contains Business "Managers" and "Engines" that encapsulate core business use cases and their variants
        1) Managers can call Engines and Resource Access layer
        1) Engines can call Resource Access layer
        1) Other interactions use publish/subscribe or non-dependent queueing
    1) Has no knowledge of API data contracts or logic (no reference to Entity Framework)
    1) Maps Business DTOs to RAOs
1) SIS.Business.Tests

#### Resource Access Layer
Depends only on a connection to the SIS database and Entity Framework.
1) SIS.Database.DataContract
    1) Contains Resource Access objects suffixed with "RAO" (Resource Access Objects)
    2) Contains Interfaces for Command pattern, suffixed with "Command", "Invoker", & "Receiver"
1) SIS.Database
    1) Command Pattern: Command, Invoker, and Receiver classes should be placed in appropriately folders, for instance "Authorization". Keeping folder names parallel with with "Business" layer folders is requested when possible and appropriate.
    2) Queries/commands use business verbs over CRUD-only where appropriate, and should be suffixed with "Command", "Invoker", or "Receiver". As of now, these should have singular endings. A class should not have multiple "commands". For exaaple, to register a new user, the class names are as follows: "RegisterCreateUserReceiver", "RegisterCreateUserInvoker", and "RegisterCreateUserCommand".
    3) This layer should be kept highly encapsulated and has no knowledge of Business data contracts or logic. DTOs are passed in through Invoker methods(or other pattern as needed), but no contracts are known.
    4) This layer should maps RAOs to entities. 
    5) This layer will contain entities that are mapped to the DB and are suffixed by with the word "Entity". For instance, UserEntity.


1) SIS.Database.Tests

#### Utility Layer
Accessible from any layer, all code here must depend on System libraries only and cannot encapsulate any knowledge of the Business or any Resource Access layer.
1) SIS.Common
1) SIS.Common.Tests

#### Integration Tests
The more complicated use cases of SIS can be tested in integration here for refactor and maintenance confidence.
1) SIS.IntegrationTests
1) Postman Collection


## Outstanding Project Decisions
1) Object-to-object mapping tool (recommend [AutoMapper](https://automapper.org/))
