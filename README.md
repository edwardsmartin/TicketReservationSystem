# Ticket Reservation System
A Visual C# Windows Forms Application to manage a simple __tickets reservation system.__ It is required to create a __database__ file that contains at least three related tables, the first of which contains the __event records__ within the following fields:
- event ID number
- event description/title
- date and time
- price
- number of seats available
- number of seats sold

The second table should contain the __customer information__, such as:
- customer ID
- first name
- last name
- address
- telephone number
- credit card info

The third table contains the data of the tickets purchased including the selected fields from the first two tables, as well as a seat number.

The program contains multiple Windows forms as follows:
- The __first form__ will enable the user to search for the events information. If an event selection has been made, __the second form__ will enable the user to purchase the tickets for this event, or return to the previous form and search for another event. If the purchase has been made the next form will display a receipt, which contains the customer and the purchased tickets data, as well as the total cost including all taxes. When a customer order is processed __the database file is updated__, new records are __added__ to the third table and the second table (optional, if it is a new customer), and the number of seats available as well as the number of seats sold is __updated__ in the first table.

__Exception handling techniques__ are used to prevent a variety of possible run-time errors. A user-friendly design is used for the form to contain images of the selected events.

__Project documentation__ has also been created that includes:
1. A user manual, i.e. information on how to use the application
2. Screen captures of all forms with __sample I/O__ and the __source code__ of each form's class
3. Samples of your database tables, including sample data
