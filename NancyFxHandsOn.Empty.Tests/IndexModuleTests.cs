using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Testing;
using NancyFxHandsOn.Empty.Modules;

namespace NancyFxHandsOn.Empty.Tests
{
    [TestClass]
    public class IndexModuleTests
    {
        [TestMethod]
        public void EmptyUriReturnsHelloNancy()
        {
            // Given
            var bootstrapper = new DefaultNancyBootstrapper();
            var browser = new Browser(bootstrapper);

            // When
            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            // Then
            Assert.AreEqual("Hallo Nancy!", result.Body.AsString());
        }

        [TestMethod]
        public void HelloGreetsNameWithCustomGreeter()
        {
            // Given
            var bootstrapper = new ConfigurableBootstrapper(with =>
            {
                with.Module<IndexModule>();
                with.Dependency<IInjectee>(new CustomGreeter());
            });
            var browser = new Browser(bootstrapper);

            // When
            var result = browser.Get("/hello/Martin", with =>
            {
                with.HttpRequest();
            });

            // Then
            Assert.AreEqual("Hello Martin.", result.Body.AsString());
        }

        [TestMethod]
        public void RestReturnsRest()
        {
            // Given
            var bootstrapper = new DefaultNancyBootstrapper();
            var browser = new Browser(bootstrapper);

            // When
            var result = browser.Get("/foo", with =>
            {
                with.HttpRequest();
            });

            // Then
            Assert.AreEqual("You accessed: foo", result.Body.AsString());
        }

        private class CustomGreeter : IInjectee 
        {
            public string Greeter(string name)
            {
                return string.Format("Hello {0}.", name);
            }
        }
    }
}
