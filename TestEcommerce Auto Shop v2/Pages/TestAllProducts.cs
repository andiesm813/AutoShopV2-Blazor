using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Ecommerce_Auto_Shop_v2.Pages;

namespace TestEcommerce_Auto_Shop_v2
{
	public class TestAllProducts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbCardModule));
			var componentUnderTest = ctx.RenderComponent<AllProducts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}