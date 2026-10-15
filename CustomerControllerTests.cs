using BankingApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests
{
    [TestClass]
    public class CustomerControllerTests
    {
        [TestMethod]
        public void AddCustomerWorks()
        {
            CustomerController controller = new CustomerController();
            controller.AddCustomer("C001", "Sam", "sam@email.com", false);
            Assert.AreEqual("Sam", controller.GetCustomer("C001").Name);
            Assert.AreEqual(1, controller.GetAllCustomers().Count);
        }

        [TestMethod]
        public void DuplicateCustomerThrowsException()
        {
            CustomerController controller = new CustomerController();
            controller.AddCustomer("C001", "Sam", "sam@email.com", false);
            Assert.ThrowsException<BankingException>(() =>
                controller.AddCustomer("C001", "Alex", "alex@email.com", false));
        }

        [TestMethod]
        public void EmptyCustomerNameThrowsException()
        {
            CustomerController controller = new CustomerController();
            Assert.ThrowsException<BankingException>(() =>
                controller.AddCustomer("C001", "", "sam@email.com", false));
        }

        [TestMethod]
        public void UpdateCustomerWorks()
        {
            CustomerController controller = new CustomerController();
            controller.AddCustomer("C001", "Sam", "sam@email.com", false);
            controller.UpdateCustomer("C001", "Alex", "alex@email.com", true);
            Assert.AreEqual("Alex", controller.GetCustomer("C001").Name);
            Assert.IsTrue(controller.GetCustomer("C001").IsBankStaff);
        }

        [TestMethod]
        public void DeleteCustomerWorks()
        {
            CustomerController controller = new CustomerController();
            controller.AddCustomer("C001", "Sam", "sam@email.com", false);
            controller.DeleteCustomer("C001");
            Assert.IsNull(controller.GetCustomer("C001"));
        }

        [TestMethod]
        public void MissingCustomerThrowsException()
        {
            CustomerController controller = new CustomerController();
            Assert.ThrowsException<BankingException>(() => controller.DeleteCustomer("C999"));
        }

        [TestMethod]
        public void EachCustomerHasThreeAccounts()
        {
            CustomerController controller = new CustomerController();
            controller.AddCustomer("C001", "Sam", "sam@email.com", false);
            Assert.AreEqual(3, controller.GetCustomerAccounts("C001").Count);
        }

        [TestMethod]
        public void ControllerDepositAndHistoryWork()
        {
            CustomerController controller = new CustomerController();
            controller.AddCustomer("C001", "Sam", "sam@email.com", false);
            controller.Deposit("C001", "Investment Account", 100m);
            Assert.AreEqual(100m, controller.GetAccountBalance("C001", "Investment Account"));
            Assert.AreEqual(1, controller.GetHistory("C001").Count);
        }

        [TestMethod]
        public void FailedWithdrawalDoesNotAddHistory()
        {
            CustomerController controller = new CustomerController();
            controller.AddCustomer("C001", "Sam", "sam@email.com", false);
            Assert.ThrowsException<BankingException>(() =>
                controller.Withdraw("C001", "Everyday Account", 1m));
            Assert.AreEqual(0, controller.GetHistory("C001").Count);
        }
    }
}
