using Moq;
using Ninject.Tests.Fakes;
using Xunit;
using Xunit.Should;

namespace Ninject.Moq.Tests
{
    public class ImplicitBindingContext
    {
        protected readonly MockingKernel kernel;

        public ImplicitBindingContext()
        {
            kernel = new MockingKernel();
        }
    }

    public class ImplicitBindingTests : ImplicitBindingContext
    {
        [Fact]
        public void DependenciesAreResolvedUsingMockedObjects()
        {
            var samuari = kernel.Get<Samurai>();
            samuari.Weapon.ShouldNotBeNull();
            samuari.Weapon.ShouldBeInstanceOf(new Mock<IWeapon>().Object.GetType());
        }
    }
}
