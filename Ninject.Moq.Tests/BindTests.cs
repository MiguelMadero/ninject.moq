using Moq;
using Ninject.Tests.Fakes;
using Xunit;
using Xunit.Should;

namespace Ninject.Moq.Tests
{
    public class BindContext
    {
        protected readonly StandardKernel kernel;

        public BindContext()
        {
            kernel = new StandardKernel();
        }
    }

    public class BindTests : BindContext
    {
        [Fact]
        public void ShouldCreateMock()
        {
            kernel.Bind<Samurai>().ToMock();
            var samurai = kernel.Get<Samurai>();
            samurai.Weapon.ShouldBeInstanceOf(new Mock<IWeapon>().Object.GetType());
        }
    }
}
