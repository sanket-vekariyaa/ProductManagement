using Microsoft.AspNetCore.Components;
using ProductManagement.Business;
using ProductManagement.Model;
using ProductManagement.Provider;

namespace ProductManagement.Components.Product
{
    public partial class Add : ComponentBase
    {
        private Products newProduct = new Products();

        [Inject]
        public ProductService ProductService { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var response = await ProductService.Get<Category>(0);
            newProduct.CategoryList = TypeHelper.SafeCastToList<Category>(response.Data);
            //if(!newProduct.CategoryList.Any()) // we will move this code into seed method
            //{
            //    newProduct.CategoryList = await ProductService.SaveProductCategories();
            //}
        }

        private async Task HandleValidSubmit()
        {
            var response = await ProductService.Save(newProduct);
            if (response.Status == (byte)StatusFlags.Success)
            {
                NavigationManager.NavigateTo("/index");
            }
            else
            {
                Console.WriteLine($"Error: {response.Message}");
            }
        }
    }
}
