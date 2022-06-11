// See https://aka.ms/new-console-template for more information
using Linq_Address_Book;

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
//Retrieve based on city or state
string var3 = dataTableManger.RetrieveBasedOnCityorState("Bareilly", "UP");
Console.WriteLine("Success" + varl);
//count based on city or state
string var4 = dataTableManger.RetrieveCountBasedOnCityorState();
Console.WriteLine("Success" + varl);
//sort based on name in data table
string var5 = dataTableManger.SortBasedOnNameInDataTable("chennai");
Console.WriteLine("Success" + varl);
        
    



