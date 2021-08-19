-- Create Database : 

create database addressbook;

-- Use Database : 
use addressbook;

-- Creating Table :
create table AddressBook
(
	SNO int identity primary key,
	FirstName varchar(20),
	LastName varchar(20),
	Address varchar(100),
	City varchar(20),
	State varchar(20),
	ZipCode varchar(6),
	PhoneNumber varchar(10),
	EmailId varchar(30)
);

-- Creating Procedure :
