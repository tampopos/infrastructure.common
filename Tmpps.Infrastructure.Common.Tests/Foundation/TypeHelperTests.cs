using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Tmpps.Infrastructure.Common.Foundation;
using Tmpps.Infrastructure.Common.Foundation.Interfaces;

namespace Tmpps.Infrastructure.Common.Tests.Foundation
{
    [TestClass]
    public class TypeHelperTests
    {
        [TestMethod]
        public void GetTypeTest()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyHelper = new Mock<IAssemblyHelper>();
            assemblyHelper.Setup(x => x.GetExecuteAssembly()).Returns(assembly);
            var instance = new TypeHelper(assemblyHelper.Object);
            Assert.AreEqual(typeof(TypeHelperTests), instance.GetType(x => x.Name == nameof(TypeHelperTests)));
        }
    }
}