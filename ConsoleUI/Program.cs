// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//SOLID 
//O:Open Closed Principle=Yaptığın yazılıma yrni bir özellik ekliyorsan mevcuttaki kodlara dokunamazsın.
//Gelişime açık değişime kapalıdır.Öyle olması gerekir.İyi bir kod yazıldıysa.
//ProductManager productManager = new ProductManager(new InMemoryProductDal()); //plug in play 

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetByUnitPrice(50,100)) 
{
    Console.WriteLine(product.ProductName);
}