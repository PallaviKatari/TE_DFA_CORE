create database TE_Core_MVC

use TE_Core_MVC

create table Trainees
(
TID int Primary Key Identity(1,1),
TName varchar(25),
TAge int check(TAge>=22)
)

select * from Trainees

drop table Trainees

set identity_insert Trainees on