using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Ecommerce_Auto_Shop_v2.Pages;

namespace TestEcommerce_Auto_Shop_v2
{
	public class TestProductDetails
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbRatingModule),
				typeof(IgbBadgeModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbCardModule));
			var componentUnderTest = ctx.RenderComponent<ProductDetails>();
			Assert.NotNull(componentUnderTest);
		}
	}
}