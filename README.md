Background:
An online retail store is developing a software system to manage its core operations, including products, orders, customers, and inventory. The system supports multiple product categories, such as electronics, clothing, and groceries, each having unique attributes.

Requirements:
Product Categories: The system manages different product types with specific properties:

Electronics: Have a warranty period.
Clothing: Include size and material details.
Groceries: Have an expiration date.
Order Management: Customers can place orders containing multiple products. Each order tracks the order date, delivery date, and current status.

Inventory Management: The system handles stock levels, automatically updating inventory when products are sold or returned.

Class Structure & Inheritance: The system focuses on a simplified design using inheritance and method overloading to implement functionality for products, orders, and inventory.

Tasks:
Class Design:

Design and implement the class hierarchy for the store. This includes abstract classes like Product and derived classes like Electronic, Clothing, and Grocery.
Implement necessary properties and methods for each class, ensuring proper inheritance.
Order Class:

Write overloaded constructors to allow order creation with different sets of initial data (e.g., a list of products or product IDs with quantities).
Implement a method to calculate the total cost of an order, factoring in bulk discounts where applicable.
Inventory Management:

Implement a method to update stock levels when an order is placed, ensuring that the system tracks product availability in real time.
Return Processing:

Implement functionality in the Order class to handle product returns, ensuring inventory is updated correctly. For groceries, check the expiration date before processing returns to avoid restocking expired products.
This system serves as a foundation for expanding functionality in future iterations, allowing the store to efficiently manage products, orders, and inventory
