using _2_ModifyDataTableBasedonName;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactManagerTesting2
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
    }
}

    
