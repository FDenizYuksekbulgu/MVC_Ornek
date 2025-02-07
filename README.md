
# MVC Project
Task: Display Customer and Order Information
We are developing an application to display customer and order information using ASP.NET MVC by following the steps below.

## Step 1: Creating the Model
Customer Model:

A Customer class is created.

Id (Unique ID of the customer, int type)

FirstName (Customer's name, string type)

LastName (Customer's last name, string type)

Email (Customer's email address, string type)

Order Model:

A Order class is created.

Id (Unique ID of the order, int)

ProductName (Name of the product, string)

Price (Price of the product, decimal)

Quantity (Quantity of the product ordered, int)

## Step 2: Creating the ViewModel
CustomerOrderViewModel Class:

A CustomerOrderViewModel class is created.

Customer (A Customer object)

Orders (A list of Order objects)

The ViewModel will hold the model data and any additional information needed to display in the view.

## Step 3: Creating the Controller
CustomerOrdersController:

A CustomerOrdersController class is created.

An action method named Index is created in this controller.

In the Index method:

A sample Customer object and several Order objects are created.

A CustomerOrderViewModel object is created using these objects.

The CustomerOrderViewModel object is passed to the view.

## Step 4: Creating the View
Index View:

A view named Index.cshtml is created under the Views/CustomerOrders folder.

This view will display customer information and orders using the CustomerOrderViewModel.

In the View:

Customer information (ID, name, surname, email) is displayed.

A table of orders is created and the order ID, product name, price and quantity information is listed.
