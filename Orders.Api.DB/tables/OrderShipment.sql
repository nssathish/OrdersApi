CREATE TABLE [dbo].[OrderShipment]
(
  [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
  [Charges] DECIMAL NOT NULL,
  [AddressLine1] VARCHAR(100) NOT NULL,
  [AddressLine2] VARCHAR(100) NULL,
  [City] VARCHAR(100) NOT NULL,
  [State] VARCHAR(50) NOT NULL,
  [Zip] VARCHAR(10) NOT NULL,
  [OrderId] UNIQUEIDENTIFIER NOT NULL
    CONSTRAINT FK_OrderShipment_OrderId FOREIGN KEY ([OrderId]) REFERENCES dbo.[Order]([Id]),
  [OrderItemId] UNIQUEIDENTIFIER NOT NULL CONSTRAINT FK_OrderItemId FOREIGN KEY
  ([OrderItemId]) REFERENCES dbo.[OrderItem]
  ([Id]),
  [Created] DATETIME2 NOT NULL,
  [CreatedBy] VARCHAR(50) NOT NULL,
  [Lastmodified] DATETIME2 NULL,
  [LastmodifiedBy] VARCHAR(50) NULL,
  [Deleted] DATETIME2 NULL,
  [DeletedBy] VARCHAR(50) NULL
)
