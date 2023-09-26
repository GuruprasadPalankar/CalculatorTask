using System;
using System.Web.Mvc;
using CalculatorLogic;
using CalculatorTask.Controllers;
using CalculatorTask.Models;
using NUnit.Framework;
using Moq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorHomeControllerTest
{
    [TestFixture]
    public class HomeControllerTest
    {
        [TestCase(0, "Index")]
        [TestCase(7, "Index")]
        public void HomeControllerTestMethod_ReturnsIndexView(int solution, string viewName)
        {
            //Act
            var mock = new Mock<ILogic>();
            mock.Setup(x => x.SolutionPart(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<string>())).Returns(solution);
            var homeController = new HomeController(mock.Object);

            var number = new NumbersModel()
            {
                Number1 = It.IsAny<double>(),
                Number2 = It.IsAny<double>(),
                Solution = 0
            };

            var output = homeController.Display(number, It.IsAny<string>()) as ViewResult;

            //Assert
            Assert.AreEqual(number.Solution, solution);
            Assert.AreEqual(output.ViewName, viewName);
        }
    }
}
