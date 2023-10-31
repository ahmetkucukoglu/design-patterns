using DecoratorDesignPattern;

var productService = new ProductService();
productService.GetProducts();

Console.WriteLine("------");

var cacheProductService = new CacheProductService(new ProductService());
cacheProductService.GetProducts();

Console.WriteLine("------");

var logProductService = new LogProductService(new CacheProductService(new ProductService()));
logProductService.GetProducts();