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
ALTER TABLE Store.Customers ADD CONSTRAINT [FK_CustomerLocationId]
    FOREIGN KEY (LocationId) REFERENCES Store.Location (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_CustomerLocationId] ON Store.Customers (LocationId);




