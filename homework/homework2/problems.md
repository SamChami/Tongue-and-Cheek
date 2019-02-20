##  Problems from Ch 5 and 6
####  Sam Chami, Merci Magallanes, and John Scott

###  Problem 5.1, Stephens page 116

What's the difference between a component-based architecture and a service-oriented architecture?
>  In *component-based software engineering*, you regard the system as a collection of loosely coupled components that provide services for each other. A *component-based architecture* decouples the pieces of code much as a multi-tier architecture does, but all the pieces are all contained within the same executable program, so they communicate directly instead of across a network. A *service-oriented architecture* is similar to component-based architecture except the pieces are implemented as services. A *service* is a self-contained program that runs on its own and provides some kind of service for its clients.

###  Problem 5.2, Stephens page 116

Suppose you're building a phone application that lets you play tic-tac-toe against a simple computer opponent. It will display high scores stored on the phone, not in an external database. Which architectures would be most appropriate and why?
>  Monolithic architecture because everything would be built into a single application so there's no need for complicated communication across networks. Event-driven architecture because it makes sense that after the user interacts with the interface/game the application should react in a way based on what the user did. Rules-based architecture because the game tic-tac-toe has rules that both the user and computer opponent should adhere to.

###  Problem 5.4, Stephens page 116

Repeat question 3 [after thinking about it; it repeats question 2 for a chess game] assuming the chess program lets two users play against each other over an Internet connection.
>  Client/server and multi-tier architecture because it would be great for users to access the client side of the application, manipulate data in a database (game properties/objects), and communicate over a network. Possibly service-oriented architecture since it would be if I wanted to implement the chess program as a web service. Rules-based architecture because the game chess has rules that both users should adhere to.

###  Problem 5.6, Stephens page 116

What kind of database structure and maintenance should the `ClassyDraw` application use?
>  The `ClassyDraw` application should use a relational database to keep track of components of drawings and the drawings themselves and a data warehouse to hold old data before eventually removing it if the application gets too slow.

###  Problem 5.8, Stephens page 116

Draw a state machine diagram to let a program read floating point numbers in scientific notation as in +37 or -12.3e+17 (which means -12.3 x 10<sup>17</sup>). Allow both E and e for the exponent symbol. [Jeez, is this like Dr. Dorin's DFAs, or ***what***???]
>  TODO

###  Problem 6.1, Stephens page 138

Consider the `ClassyDraw` classes `Line`, `Rectangle`, `Ellipse`, `Star`, and `Text`. What properties do these classes all share? What properties do they not share? Are there any properties shared by some classes and not others? Where should the shared and non-shared properties be implemented?
>  TODO

###  Problem 6.2, Stephens page 138

Draw an inheritance diagram showing the properties you identified for Exercise 1. (Create parent classes as needed, and don't forget the `Drawable` class at the top.)
>  TODO

###  Problem 6.3, Stephens page 139

The following list gives the properties of several business-oriented classes.

*  Customer — Name, Phone, Address, BillingAddress, CustomerID
*  Hourly — Name, Phone, Address, EmployeeID, HourlyRate
*  Manager — Name, Phone, Address, EmployeeID, Office, Salary, Boss, Employees
*  Salaried — Name, Phone, Address, EmployeeID, Office, Salary, Boss
*  Supplier — Name, Phone, Address, Products, SupplierID
*  VicePresident — Name, Phone, Address, EmployeeID, Office, Salary, Managers

Assuming a `Supplier` is someone who supplies products for your business, draw an inheritance diagram showing the relationships among these classes. (Hint: Add extra classes if necessary.)
>  TODO

###  Problem 6.6, Stephens page 139

Suppose your company has many managerial types such as department manager, project manager, and division manager. You also have multiple levels of vice president, some of whom report to other manager types. How could you combine the `Salaried`, `Manager`, and `VicePresident` types you used in Exercise 3? Draw the new inheritance hierarchy.
>  TODO
