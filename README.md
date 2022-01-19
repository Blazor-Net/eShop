# E-Shop in Blazor.Net 

# Customer potal :  

# Step no : 1 ( Load the project from the above Link)
![image](https://user-images.githubusercontent.com/11761314/150029206-6e798c76-9ff0-4c18-bb78-9519cc9340c1.png)
# Step no : 2 ( Register New User)
![image](https://user-images.githubusercontent.com/11761314/150029961-bdbffa9f-d02d-460a-8023-a0332bbee96f.png)
# Step no : 3 ( Login New User)
![image](https://user-images.githubusercontent.com/11761314/150127143-617f1f6f-335b-4a31-9552-5d491ac75711.png)
![image](https://user-images.githubusercontent.com/11761314/150128188-9c5ed980-2a80-4192-a8d5-daf39bfbe8dc.png)
# Step no : 4 ( Product Catalog Page)
![image](https://user-images.githubusercontent.com/11761314/150128316-04439648-4449-4302-9fb8-28f79f0d5339.png)
# Step no : 5 ( Add to shopping Cart)
![image](https://user-images.githubusercontent.com/11761314/150129154-74bb7b5e-0d3e-4f50-8779-92e3df10fdff.png)
# Step no : 6 ( Shopping Cart Block)
![image](https://user-images.githubusercontent.com/11761314/150129599-95468333-9c71-488a-ac00-f2b461651d66.png)
# Step no : 7 ( Placing order page)
![image](https://user-images.githubusercontent.com/11761314/150129845-805b452a-b073-445c-958f-503d43ea2a7a.png)
# Step no : 8 ( Order Confirmation page)
![image](https://user-images.githubusercontent.com/11761314/150129900-77534db7-ed95-4491-be1e-47f1db7da6e1.png)

------------------------------------------------------------------------------------------------------------------------
# Admin Portal: (Adminnistration of Orders)

# Step no : 1 ( Admin can login with their own credentials in the same Login Page where user can login for access product catalog page)
![image](https://user-images.githubusercontent.com/11761314/150131621-df16b587-93b6-43c7-b569-5cda66d043b0.png)
In this Page Admin can process unprocessed orders and perform some administartion work in terms of handling user and product catalog information.
![image](https://user-images.githubusercontent.com/11761314/150132238-69b0c3c3-517c-46ec-a6c4-a92e996b05a0.png)
# Step no : 2 ( Admin can see unprocessed orders)
![image](https://user-images.githubusercontent.com/11761314/150132547-ca9a5c54-1d68-478d-9721-eb61f389659f.png)
# Step no : 3 ( Process the unprocessed orders)
![image](https://user-images.githubusercontent.com/11761314/150132673-a5efe437-a246-4535-8f17-cd35282076e2.png)
# Step no : 4 ( Admin can see the processed orders)
![image](https://user-images.githubusercontent.com/11761314/150132761-0a6e35d1-4216-4040-ad26-d0e1c1abdfee.png)
# Step no : 5( Admin can perfrom User administration)
![image](https://user-images.githubusercontent.com/11761314/150132975-538d9ffc-62f0-4e1d-b0f5-7b1b5c9ad909.png)
--------------------------------------------------------------------------------------------------------------------------------

# Code implementation:
Below diagram shows complete code implementation , I used Clean architecture design pattern which is provided by Microsoft for handling the Blazor .Net Projects 

![image](https://user-images.githubusercontent.com/11761314/150133249-8d9679ba-ad26-470f-a2b6-6c75754bb36c.png)

## .Net Projects separation details : 
 - eShop.WEB
 - eShop.UseCases
 - eShop.CoreBusiness
 - Demo Dapper
 1. **eShop.Web.Modules**
    - eShop.Web.AdminPortal
    - eShop.Web.CustomerPortal
    - eShop.Web.Common
 2. **Plugins**
    - eShop.DataStore.HardCoded
    - eShop.DataStore.SQL.Dapper
    - eShop.ShoppingCart.LocalStorage
    - eShop.StateStore.DependencyInjection


## What is eShop.WEB ?

 eShop.WEB is a Blazor .Net assembly project which consist of all razor components . This project holds the main UI Login and razor page settings. This is a core project we always run this project first because it contain all other projects references.  
![image](https://user-images.githubusercontent.com/11761314/150142107-2b1ad35f-4194-45f7-a87d-ded590a39be0.png)

## What is eShop.UseCases ?
This project completely seperarte our Use cases logic forexample order detail screen , unprocessed orders , process orders. You can evaluate How I separate all apllication busines logic from each other and No modules are dependent to each other. one chang can not damage to other module. This is actuall essence of DI concept. 

![image](https://user-images.githubusercontent.com/11761314/150142552-274c0198-e14e-430c-b3a4-520f3882bf19.png)

## What is eShop.CoreBusiness ?
In this project I written only business or application specfic classes and oder services 
![image](https://user-images.githubusercontent.com/11761314/150143196-c95c8950-755c-40bc-993c-da912a6d9155.png)

 ## What is DemoDapper ?
 THis project simply connect our backend server logic to SQL server database. Demo Dapper is like a Bridge act  between backend logic to Data access layer logic.

## what is eShop.Web.Modules ?
This module is specific to admin portal , customer portal and common classes 
![image](https://user-images.githubusercontent.com/11761314/150144138-f332c1b0-b61b-4db3-b99f-48123c03e65c.png)

## what is Plugins ?
This project specifically used for shopping Cart module, you can see in this project How Page can handle shopping Cart items without loosing the state. All that occuring via respecting projects 
    - eShop.DataStore.HardCoded
    - eShop.DataStore.SQL.Dapper
    - eShop.ShoppingCart.LocalStorage
    - eShop.StateStore.DependencyInjection
![image](https://user-images.githubusercontent.com/11761314/150144485-4e4b3385-25d2-442c-ab1e-db8c74ffe3e8.png)





