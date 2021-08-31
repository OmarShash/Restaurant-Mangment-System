# Restaurant-Mangment-System
 ## By C#
 
- Restaurant management system helps you capture transactions and manage inventory with accuracy and generally run everyday processes more efficiently,designed for the foodservice industry.
## Class Digram For Restaurant Mangment System
![restaurant_management_system](https://user-images.githubusercontent.com/52002880/131529017-8ff0158b-1039-47c5-8e42-c65168a59aad.jpg)

- The System reduces the hectic of managing food orders, delivery employees and tracking inventory items Manually such that:
  - Orders from customers are accepted and bills are calculated automatically.
  - Food categories and ingredient products are managed and tracked automatically.
  - Automatic Management of the delivery boys.
  - The Ability to rank food products by customers is a considerable requirement.
  - Automatic generation of vouchers/promotions to get special offers on food products.

- There are 2 types of system users:
  - Customer: Characterized by an ID, Name, Mobile number, specified address, list of orders.
  - Restaurant Manager: Characterized by a Name, Mobile Number, username Password.

- The users of the system deal with:
  - A Menu Item/food product: That is Characterized by item code/ID, Name, rate/rank, unit price, A photo illustrating the item.
  - An inventory Item: is a Menu item + units sold, quantity available.
  - An inventory: contains inventory items.
  - A Category: That is characterized by a list of Menu Items/Food products, Name.
  - A Main Menu: That is Characterized by a list of Categories, Restaurant Name.
  - An Order: That is characterized by an ID, list of Menu items/food products, amount of each product, Customer Name, Customer ID, Customer Address Customer Mobile Number, estimated delivery time, associated delivery boy, Received Status, Complain message.
  - A Bill: That is characterized by an ID, Date, all Order attributes, delivery charges, total cash amount, Voucher/promotion ID, Voucher's discount percentage, total cash after discount,
  - A Voucher/Promotion: That is Characterized by an ID, discount percentage amount, release date, expiration date.
  - An Announcement for special offers: That is Characterized by Restaurant Manager Name, a Message, A list of Menu Items/food products.
  - Delivery Boy: That is Characterized by ID, Name, Working hours, availability status, list of orders.

- Functional Requirements: 
  - The Customer must register his info in a profile on the system.
  - The Customer and the Restaurant Manager can login or logout with a username and password.
  - The Restaurant Manager can create A main menu and add menu items/food products to it.
  - The Restaurant Manager can add, delete and view inventory food items of the inventory.
  - The customer or the Restaurant Manager can view the main menu.
  - The customer can rate a food item [1 to 5 Stars].
  - The customer can place an order.
  - A Customer can cancel an order within 10 minutes after it has been issued.
  - The system has the ability to track quantities available in the inventory and products sold from customer's orders.
  - The Restaurant Manager can publish an announcement of special offers in the main menu.
  - The System is able to provide a promotion/voucher for the customer's orders that exceeds 1000 L.E (e.x 20% discount).
  - The Customer Gets A voucher with” 30% discount” from the total order Price when he first creates an account.
  - The Restaurant Manager can manage the employees who deliver the orders to the customers and assign orders to them.
  - Each delivery boy cannot deliver more than 2 orders at a time.
  - The Customer can return the order after receiving it and send a complain to the restaurant about the state/quality of the returned food (not fresh-not warm..etc).
