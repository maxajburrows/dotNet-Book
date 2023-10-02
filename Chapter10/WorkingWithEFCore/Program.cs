using Packt.Shared;

// QueryingCategories();
// FilteredIncludes();
// QueryingProducts();
// QueryingWithLike();
//GetRandomProduct();
// var resultAdd = AddProduct(categoryId: 6, productName: "Super Seafood", price: 700M);
// if (resultAdd.affected == 1)
// {
//     WriteLine("Add product successful.");
// }
// ListProducts(productIdToHighlight: resultAdd.productId);
var resultUpdate = IncreaseProductPrice(productNameStartsWith: "Bob", amount: 20M);
if (resultUpdate.affected == 1)
{
    WriteLine("Increase product price successful.");
}
ListProducts(productIdToHighlight: resultUpdate.productId);