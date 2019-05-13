CREATE TABLE Store.Customers
(
    Id INT NOT NULL,
    FirstName NVARCHAR(160) NOT NULL,
    LastName NVARCHAR(160) NOT NULL,
    PhoneNumber VARCHAR(10) NOT NULL,
    LocationId INT NOT NULL,
    CONSTRAINT PK_Customers PRIMARY KEY CLUSTERED (Id)
);

CREATE TABLE Store.Location
(
    Id INT NOT NULL,
    Name NVARCHAR(160) NOT NULL,
    Street NVARCHAR(160) NOT NULL,
    City NVARCHAR(160) NOT NULL,
    State VARCHAR(2) NOT NULL,
    CONSTRAINT PK_Location PRIMARY KEY CLUSTERED (Id)
);
-- sp_rename 'Store.Location.PK_Orders', 'PK_Location'; 
--ALTER TABLE Store.Location
  --ADD Inventory int,
      --column_2 column_definition,


CREATE TABLE Store.Orders
(
    Id INT NOT NULL,
    Time SMALLDATETIME NOT NULL,
    CustomerId INT NOT NULL,
    LocationId INT NOT NULL,
    --OrderItemId INT NOT NULL,
    CONSTRAINT PK_Orders PRIMARY KEY CLUSTERED(Id)
)
--ALTER TABLE Store.Orders DROP COLUMN "OrderItemID"

CREATE TABLE Store.OrderItem
(
    Id INT NOT NULL,
    OrderId INT NOT NULL,
    ProductId INT NOT NULL,
    CONSTRAINT PK_OrderItem PRIMARY KEY CLUSTERED(Id)
)


CREATE TABLE Store.Product
(
    Id INT NOT NULL,
    Name NVARCHAR(160) NOT NULL,
    Price INT NOT NULL,
    --CustomerId INT NOT NULL,
    --LocationId INT NOT NULL,
    --OrderItemId INT NOT NULL,
    CONSTRAINT PK_Product PRIMARY KEY CLUSTERED(Id)
)
DELETE FROM Store.Product


CREATE TABLE Store.InventoryItem
(
    Id INT NOT NULL,
    LocationId INT NOT NULL,
    ProductId INT NOT NULL,
    CONSTRAINT PK_InventoryItem PRIMARY KEY CLUSTERED(Id)
)

-- Foreign Key: Customer => LocationId
ALTER TABLE Store.Customers ADD CONSTRAINT [FK_CustomerLocationId]
    FOREIGN KEY (LocationId) REFERENCES Store.Location (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_CustomerLocationId] ON Store.Customers (LocationId);

-- Foreign Key: Order => LocationId
ALTER TABLE Store.Orders ADD CONSTRAINT [FK_OrderLocationId]
    FOREIGN KEY (LocationId) REFERENCES Store.Location (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_OrderLocationId] ON Store.Orders (LocationId);

-- Foreign Key: Order => CustomerId
ALTER TABLE Store.Orders ADD CONSTRAINT [FK_OrderCustomerId]
    FOREIGN KEY (CustomerId) REFERENCES Store.Customers (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_OrderCustomerId] ON Store.Orders (CustomerId);

-- Foreign Key: OrderItem => OrderId
ALTER TABLE Store.OrderItem ADD CONSTRAINT [FK_OrderItemOrderId]
    FOREIGN KEY (OrderId) REFERENCES Store.Orders (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_OrderItemOrderId] ON Store.OrderItem (OrderId);

-- Foreign Key: OrderItem => ProductId
ALTER TABLE Store.OrderItem ADD CONSTRAINT [FK_OrderItemProductId]
    FOREIGN KEY (ProductId) REFERENCES Store.Product (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_OrderItemProductId] ON Store.OrderItem (ProductId);

-- Foreign Key: InventoryItem => LocationId
ALTER TABLE Store.InventoryItem ADD CONSTRAINT [FK_InventoryItemLocationId]
    FOREIGN KEY (LocationId) REFERENCES Store.Location (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_InventoryItemLocationId] ON Store.InventoryItem (LocationId);

-- Foreign Key: InventoryItem => ProductId
ALTER TABLE Store.InventoryItem ADD CONSTRAINT [FK_InventoryItemProductId]
    FOREIGN KEY (ProductId) REFERENCES Store.Product (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_InventoryItemProductId] ON Store.InventoryItem (ProductId);

INSERT INTO Store.Product (Id, Name, Price) VALUES (1, 'Burger', $5);
INSERT INTO Store.Product (Id, Name, Price) VALUES (2, 'Fries', $2);
INSERT INTO Store.Product (Id, Name, Price) VALUES (3, 'Drink', $1);

INSERT INTO Store.Customers (Id, FirstName, LastName, PhoneNumber, LocationId) VALUES (1, 'Rod', 'Salomon', 1234, 1);
INSERT INTO Store.Customers (Id, FirstName, LastName, PhoneNumber, LocationId) VALUES (2, 'John', 'Smith', 4567, 2);
INSERT INTO Store.Customers (Id, FirstName, LastName, PhoneNumber, LocationId) VALUES (3, 'Jane', 'Doe', 7891, 2);
INSERT INTO Store.Customers (Id, FirstName, LastName, PhoneNumber, LocationId) VALUES (4, 'John', 'Snow', 7865, 1);


--Insert Into a2.Orders (Id, CustomerId, ProductId) VALUES (1, 1, 1)
-- Insert Into a2.Orders (Id, CustomerId, ProductId) VALUES (2, 2, 2)
-- Insert Into a2.Orders (Id, CustomerId, ProductId) VALUES (3, 3, 3)

-- INSERT INTO a2.Customers (Id, FirstName, LastNAmeName, CardNumber) VALUES (4, 'Tina', 'Smith', 4546);
-- INSERT INTO a2.Products (Id, Name, Price) VALUES (4, 'IPhone', $200);
-- Insert Into a2.Orders (Id, CustomerId, ProductId) VALUES (4, 4, 4)

INSERT INTO Store.Location (Id, Name, Street, City, State) VALUES (1, 'Dallas store', 'Marigold Dr', 'Irving', 'TX')
INSERT INTO Store.Location (Id, Name, Street, City, State) VALUES (2, 'Austin store', 'Guadalupe St', 'Austin', 'TX')

INSERT INTO Store.Orders (Id, Time, CustomerId, LocationId) VALUES (1, '2:35 am', 1, 1)
INSERT INTO Store.OrderItem (OrderId, ProductId, Id) VALUES (1, 1, 1)
INSERT INTO Store.Orders (Id, Time, CustomerId, LocationId) VALUES (2, '2:35 pm', 2, 2)
INSERT INTO Store.OrderItem (OrderId, ProductId, Id) VALUES (2, 1, 2)
INSERT INTO Store.OrderItem (OrderId, ProductId, Id) VALUES (2, 2, 3)
INSERT INTO Store.OrderItem (OrderId, ProductId, Id) VALUES (2, 3, 4)

INSERT INTO Store.Orders (Id, Time, CustomerId, LocationId) VALUES (3, '9:13 am', 3, 2)
INSERT INTO Store.OrderItem (OrderId, ProductId, Id) VALUES (3, 2, 5)






SELECT *
FROM Store.Customers




