CREATE TABLE Payroll.Employees
(
    Id bigserial not null ,
    EmployeeNumber varchar(10),
    FirstName varchar(30),
    MiddleName varchar(30),
    LastName varchar(30),
    Gender int,
    BirthDate timestamp,
    MobileNumber varchar(10),
    TelephoneNumber varchar(20),
    EmailAddress varchar(50),
    HomeAddress varchar(150),
    SssNumber varchar(50),
    BirNumber varchar(50),
    TaxIdentificationNumber varchar(50),
    PhilHealthNumber varchar(50),
    HdmfNumber varchar(50)
);