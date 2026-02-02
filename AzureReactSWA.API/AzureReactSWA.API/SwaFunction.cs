using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace AzureReactSWA.API
{
	public class GetProductsFunction
	{
		[Function("GetProducts")]
		public IActionResult Run(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "products")] HttpRequestData req)
		{
			var products = new List<Product>
		{
			new Product { id = 10, name = "Strawberries", description = "16oz package of fresh organic strawberries", quantity = 1 },
			new Product { id = 20, name = "Sliced bread", description = "Loaf of fresh sliced wheat bread", quantity = 1 },
			new Product { id = 30, name = "Apples", description = "Bag of 7 fresh McIntosh apples", quantity = 1 }
		};
			return new OkObjectResult(products);
		}
	}
}
