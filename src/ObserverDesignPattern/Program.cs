using ObserverDesignPattern;

var product = new Product
{
    Id = 1453,
    Price = 1000M,
    Stock = 0
};

product.Attach(new ProductPriceObserver());
product.Attach(new ProductStockObserver());

product.UpdatePrice(999M);
product.UpdateStock(10);