using Microsoft.AspNetCore.Components;
using ProductManagement.Business;
using ProductManagement.Model;

namespace ProductManagement.Components.Product
{
    public partial class Add : ComponentBase
    {
        private Products newProduct = new Products();
        private List<Category> categories = new List<Category>();

        [Inject]
        public ProductService ProductService { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // Load product categories for the dropdown list
            categories = await ProductService.GetProductCategoriesAsync();
        }

        private async Task HandleValidSubmit()
        {
            // Call service to create product
            await ProductService.CreateProductAsync(newProduct);

            // Navigate back to the product list page
            NavigationManager.NavigateTo("/products");
        }
    }
}
