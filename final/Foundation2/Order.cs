public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += product.GetName() + " (ID: " + product.GetProductId() + ")\n";
        }
        return packingLabel.TrimEnd();
    }
    public string GetShippingLabel()
    {
        return _customer.GetName() + "\n" + _customer.GetAddress().GetFullAddress();
    }
}