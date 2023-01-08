CREATE TABLE [dbo].[OrderPayment]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Method] VARCHAR(50) NOT NULL,
  [Payment_Date] DATETIME2 NULL,
  [Confirmation_Number] VARCHAR(100) NULL,
  [OrderItemId] UNIQUEIDENTIFIER NOT NULL CONSTRAINT FK_OrderPayment_OrderItemId FOREIGN KEY ([OrderItemId]) REFERENCES dbo.[OrderItem]([OrderItemId]),
  [Created] DATETIME2 NOT NULL,
  [CreatedBy] VARCHAR(50) NOT NULL,
  [Lastmodified] DATETIME2 NULL,
  [LastmodifiedBy] VARCHAR(50) NULL,
  [Deleted] DATETIME2 NULL,
  [DeletedBy] VARCHAR(50) NULL
)
