using Linq_Address_Book;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManagerTest4
{
    [TestClass]
    public class UnitTest1
    {
        DataTableManager dataTableManger;

        [TestInitialize]
        public void SetUp()
        {
            dataTableManger = new DataTableManager();
        }

        [TestMethod]
        [TestCategory("Insert Values in Data Table")]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 2;
            int actual = dataTableManger.AddValues();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [TestCategory("Modify Values in Data Table")]
        public void GivenModifyValues_returnInteger()
        {
            int expected = 1;
            int actual = dataTableManger.EditDataTable("Raksha", "Lastname");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [TestCategory("Modify Values in Data Table-Negative Test Case")]
        public void GivenWrong_ModifyValues_returnInteger()
        {
            int expected = 0;
            int actual = dataTableManger.EditDataTable("mam", "Lastname");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 3: Delete values in DataTable based on Name
        [TestMethod]
        [TestCategory("Delete Row in Data Table")]
        public void GivenDeleteQuery_returnInteger()
        {
            int expected = 1;
            int actual = dataTableManger.DeleteRowInDataTable("Raksha");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [TestCategory("Delete Row in Data Table-Negative Test Case")]
        public void GivenWrongDeleteQuery_returnInteger()
        {
            int expected = 0;
            int actual = dataTableManger.DeleteRowInDataTable("lala");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 4: Retrieve values from DataTable based on City or State
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on City ")]
        public void GivenRetrieveQuery_BasedOnCityandState_returnString()
        {
            string expected = "Raksha";
            string actual = dataTableManger.RetrieveBasedOnCityorState("Lucknow", "TN");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on state ")]
        public void GivenRetrieveQuery_BasedOnCityorState_returnString()
        {
            string expected = "Raksha Parthiban";
            string actual = dataTableManger.RetrieveBasedOnCityorState("Lucknow", "UP");
            Assert.AreEqual(actual, expected);
        }
    }
}

    
