﻿User
	Id:Guid
	FirstName:string
	LastName:string
	Email:string
	Phone:string

Product
	Id:Guid
	Name:string
	Price:decimal
	Category:string

Order
	Id:Guid
	Products:List<Product>
	Price:decimal
