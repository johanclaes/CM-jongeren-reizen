using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf.Viewmodels;

namespace Groepsreizen_Tests.ViewModels
{
    [TestFixture]
    public class LoginViewModelTest
    {
        LoginViewModel lvm = new LoginViewModel();

        [Test]
        public void Login()
        {
            lvm.Email = "lb@proximus.com";
            lvm.Password = "12345";

            lvm.LoginCommand();

            Assert.That(lvm.IsTrue, Is.EqualTo(true));
        }
    }
}
