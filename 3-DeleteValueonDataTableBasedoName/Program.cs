﻿// See https://aka.ms/new-console-template for more information
using _3_DeleteValueonDataTableBasedoName;

Console.WriteLine("Welcome to LINQ AddressBookSystem!");
//Create Object for DataTable
ContactDataManager contactDataManager = new ContactDataManager();
ContactDataManager contactDataManagers = new ContactDataManager();
DataTableManager dataTableManger = new DataTableManager();
dataTableManger.CreateDataTable();

//Insert Values into Table
contactDataManager.FirstName = "Shalini";
contactDataManager.LastName = "Venkatesh";
contactDataManager.PhoneNumber = 9842905050;
contactDataManager.Email = "shalini@gmail.com";
contactDataManager.Address = "4,B Block,Avadi";
contactDataManager.City = "chennai";
contactDataManager.State = "TN";
contactDataManager.zip = 600072;
dataTableManger.InsertintoDataTable(contactDataManager);

//Insert Values into Table
contactDataManagers.FirstName = "Raksha";
contactDataManagers.LastName = "Parthiban";
contactDataManagers.PhoneNumber = 7742905050;
contactDataManagers.Email = "Raksha@gmail.com";
contactDataManagers.Address = "sasthri street,ambattur";
contactDataManagers.City = "chennai";
contactDataManagers.State = "TN";
contactDataManagers.zip = 123001;
dataTableManger.InsertintoDataTable(contactDataManagers);
dataTableManger.Display();
//Modify
int varl = dataTableManger.EditDataTable("lalita", "Lastname");
Console.WriteLine("Success" + varl);
//Delete
int var2 = dataTableManger.DeleteRowInDataTable("lalita");
Console.WriteLine("Success" + varl);
        
    


