
CREATE DATABASE [IF NOT EXISTS] saledw;

use saledw;


-- Order Management
CREATE TABLE saledw.Order_Transaction_Fact( 
Order_id bigint,
Product_id varchar(20),
Time_id varchar(20),
Customer_id varchar(20), 
Order_quantity bigint,
Unit_price bigint,
Extended_order_dollar_amount bigint
)
row format delimited  
fields terminated by ',' ; 

-- Sales
CREATE TABLE saledw.ReTail_Sales_Fact ( 
Sale_id varchar(20),
Product_id varchar(20),
Time_id varchar(20),
Store_id varchar(20),
Customer_id varchar(20),
Employee_id varchar(20), 
Supplier_id varchar(20),
Promotion_id varchar(20),
Sales_quantity bigint,
Unit_price bigint,
Discount_unit_price bigint, 
Extended_discount_dollar_amount bigint,
Extended_sales_dollar_amount bigint
)
row format delimited  
fields terminated by ',' ; 

--  Inventory
CREATE TABLE saledw.Store_Inventory_Snapshot_Fact ( 
id char(20),
Time_id varchar(20),
Product_id varchar(20),
Store_id varchar(20),
Quantity_on_hand bigint,
Product_price bigint,
Inventory_dollar_value bigint
)
row format delimited  
fields terminated by ',' ;

-- Procurement
CREATE TABLE saledw.Procurement_Transaction_Fact ( 
Procurement_id varchar(20),
Product_id varchar(20),
Store_id int,
Time_id varchar(20),
Employee_id varchar(20),
Supplier_id varchar(20),
Purchase_order_quantity bigint,
Product_price bigint,
Discount bigint,
Purchase_discount_dollar_amount bigint,
Purchase_order_dollar_amount bigint
)
row format delimited  
fields terminated by ',' ;

-- Human_Resources
CREATE TABLE saledw.Employee_Headcount_Snapshot_Fact( 
id char(20),
Time_id varchar(20),
Employee_id varchar(20),
Department_id varchar(20),
Position_id varchar(20),
Degree_id varchar(20),
Major_id varchar(20),
Salary_paid bigint,
Lunch_allowance bigint,
Fuel_allowance bigint,
Telephone_allowance bigint,
Other_allowances bigint
)
row format delimited  
fields terminated by ',' ;



-- 1. Dim_Product
CREATE TABLE Dim_Product (  
Product_id varchar(20),
Product_code varchar(13),
Product_name String, 
Product_price int,
Product_unit String,
manufacture_date date,
expiration_date date,
Product_type String,
Product_image String
)
row format delimited  
fields terminated by ',' ;

-- 2. Dim_Time
CREATE TABLE Dim_Time (  
id char(20),
Time_id varchar(20),
The_date date,
The_day char(10),
The_month char(10),
The_year char(10)
)
row format delimited  
fields terminated by ',';

-- 3. Dim_Store
CREATE TABLE Dim_Store (  
Store_id varchar(20),
Store_name String,
Province String,
District String,
Ward String,
Address String,
Phone_number varchar(13),
Store_image String,
Note String
)
row format delimited  
fields terminated by ',' ;

-- 4. Dim_Customer

CREATE TABLE Dim_Customer (  
Customer_id varchar(20),
Fullname String,
Gender String,
Date_of_birth date,
Address String,
Phone_number varchar(13),
Email String,
Customer_image String,
Accumulated_points bigint,
Customer_segment varchar(100)
)
row format delimited  
fields terminated by ',' ;

-- 5. Dim_Employee

CREATE TABLE Dim_Employee (  
Employee_id varchar(20),
Fullname String,
Gender String,
Date_of_birth date,
Address String,
Native_land String,
Phone_number varchar(13),
Email String,
Customer_image String
)
row format delimited  
fields terminated by ',' ;


-- 6. Dim_Supplier
CREATE TABLE Dim_Supplier (  
Supplier_id varchar(20),
Supplier_name String,
Address String,
Phone_number varchar(13),
Email String,
Supplier_image String
)
row format delimited  
fields terminated by ',' ;

-- 7. Dim_Department
CREATE TABLE Dim_Department (  
Department_id varchar(20),
Manager_code varchar(20),
Department_name String,
Address String
)
row format delimited  
fields terminated by ',' ;

-- 8. Dim_Month
CREATE TABLE Dim_Month (  
Month_id varchar(20),
The_month int,
The_year int
)
row format delimited  
fields terminated by ',' ;


-- 9. Dim_Major
CREATE TABLE Dim_Major (  
Major_id varchar(20),
Major_name String
)
row format delimited  
fields terminated by ',' ;

-- 10. Dim_Degree
CREATE TABLE Dim_Degree (  
Degree_id varchar(20),
Degree_name String 
)
row format delimited  
fields terminated by ',' ;   


-- 11. Dim_Position
CREATE TABLE Dim_Position (  
Position_id varchar(20),
Position_name String
)
row format delimited  
fields terminated by ',' ;   
 
 
-- 12. Dim_Promotion
CREATE TABLE Dim_Promotion (  
Promotion_id varchar(20),
Promotion_name String,
Reduced_price int,
Start_day date,
End_date date
)
row format delimited  
fields terminated by ',' ;








-- Foreign key

-- Fact_Sales
alter table Fact_Sales
add constraint FK_Fact_Sales_Dim_Product
foreign key (Product_id)
references Dim_Product(Product_id);
-- 

alter table Fact_Sales
add constraint FK_Fact_Sales_Dim_Time
foreign key (Time_id)
references Dim_Time(Time_id);
-- 

alter table Fact_Sales
add constraint FK_Fact_Sales_Dim_Store
foreign key (Store_id)
references Dim_Store(Store_id);
-- 

alter table Fact_Sales
add constraint FK_Fact_Sales_Dim_Customer
foreign key (Customer_id)
references Dim_Customer(Customer_id);
-- 

alter table Fact_Sales
add constraint FK_Fact_Sales_Dim_Employee
foreign key (Employee_id)
references Dim_Employee(Employee_id);
-- 

alter table Fact_Sales
add constraint FK_Fact_Sales_Dim_Supplier
foreign key (Supplier_id)
references Dim_Supplier(Supplier_id);
-- 

-- Fact_Inventory
alter table Fact_Inventory
add constraint FK_Fact_Inventory_Dim_Product
foreign key (Product_id)
references Dim_Product(Product_id);

alter table Fact_Inventory
add constraint FK_Fact_Inventory_Dim_Time
foreign key (Time_id)
references Dim_Time(Time_id);

alter table Fact_Inventory
add constraint FK_Fact_Inventory_Dim_Store
foreign key (Store_id)
references Dim_Store(Store_id);

alter table Fact_Inventory
add constraint FK_Fact_Inventory_Dim_Supplier
foreign key (Supplier_id)
references Dim_Supplier(Supplier_id);

-- Fact_Procurement
alter table Fact_Procurement
add constraint FK_Fact_Procurement_Dim_Product
foreign key (Product_id)
references Dim_Product(Product_id);

alter table Fact_Procurement
add constraint FK_Fact_Procurement_Dim_Time
foreign key (Time_id)
references Dim_Time(Time_id);

alter table Fact_Procurement
add constraint FK_Fact_Procurement_Dim_Employee
foreign key (Employee_id)
references Dim_Employee(Employee_id);

alter table Fact_Procurement
add constraint FK_Fact_Procurement_Dim_Supplier
foreign key (Supplier_id)
references Dim_Supplier(Supplier_id);

-- Fact_Human_Resources
alter table Fact_Human_Resources
add constraint FK_Fact_Human_Resources_Dim_Employee
foreign key (Employee_id)
references Dim_Employee(Employee_id);

alter table Fact_Human_Resources
add constraint FK_Fact_Human_Resources_Dim_Department
foreign key (Department_id)
references Dim_Department(Department_id);

alter table Fact_Human_Resources
add constraint FK_Fact_Human_Resources_Dim_Store
foreign key (Store_id)
references Dim_Store(Store_id);

alter table Fact_Human_Resources
add constraint FK_Fact_Human_Resources_Dim_Month
foreign key (Month_id)
references Dim_Month(Month_id);

-- Dim_Position Dim_Degree Dim_Major
alter table Fact_Human_Resources
add constraint FK_Fact_Human_Resources_Dim_Major
foreign key (Major_id)
references Dim_Major(Major_id);

alter table Fact_Human_Resources
add constraint FK_Fact_Human_Resources_Dim_Degree
foreign key (Degree_id)
references Dim_Degree(Degree_id);

alter table Fact_Human_Resources
add constraint FK_Fact_Human_Resources_Dim_Position
foreign key (Position_id)
references Dim_Position(Position_id);







