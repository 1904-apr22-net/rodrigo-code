Create SCHEMA a2;
Go;

CREATE TABLE a2.Products
(
    Id INT NOT NULL,
    Name NVARCHAR(120),
    Price INT NOT NULL,
    CONSTRAINT PK_Product PRIMARY KEY CLUSTERED (Id)
);


CREATE TABLE a2.Orders
(
    Id INT NOT NULL,
    CustomerId INT,
    ProductId INT,
    CONSTRAINT PK_Orders PRIMARY KEY CLUSTERED (Id)
);

CREATE TABLE a2.Customers
(
    Id INT NOT NULL,
    FirstName NVARCHAR(160) NOT NULL,
    LastNAmeName NVARCHAR(160) NOT NULL,
    CardNumber INT NOT NULL,
    CONSTRAINT PK_Customers PRIMARY KEY CLUSTERED (Id)
);

ALTER TABLE a2.Orders ADD CONSTRAINT [FK_OrderCustomerId]
    FOREIGN KEY (CustomerId) REFERENCES a2.Customers (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_OrderCustomerId] ON a2.Orders (CustomerId);

ALTER TABLE a2.Orders ADD CONSTRAINT [FK_OrdersProductId]
    FOREIGN KEY (ProductId) REFERENCES a2.Products (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
CREATE INDEX [IFK_OrderProductId] ON a2.Orders (ProductId);

INSERT INTO a2.Products (Id, Name, Price) VALUES (1, 'IPhone 3', $300);
INSERT INTO a2.Products (Id, Name, Price) VALUES (2, 'IPhone 4', $400);
INSERT INTO a2.Products (Id, Name, Price) VALUES (3, 'IPhone 5', $500);

INSERT INTO a2.Customers (Id, FirstName, LastNAmeName, CardNumber) VALUES (1, 'Rod', 'Sal', 1234);
INSERT INTO a2.Customers (Id, FirstName, LastNAmeName, CardNumber) VALUES (2, 'John', 'Smith', 4567);
INSERT INTO a2.Customers (Id, FirstName, LastNAmeName, CardNumber) VALUES (3, 'Jane', 'Doe', 7891);


