CREATE TABLE Debts
(
    DebtId         INT IDENTITY(1,1) PRIMARY KEY,
    Name           NVARCHAR(100)   NOT NULL,
    OriginalAmount DECIMAL(18,2)   NOT NULL,
    InterestRate   DECIMAL(5,2)    NOT NULL,
    DueDate        DATETIME        NOT NULL,
    DebtType       NVARCHAR(20)    NOT NULL,  
    AmountPaid     DECIMAL(18,2)   NOT NULL DEFAULT 0
);