using System;
using System.Reflection.Emit;
class Order
{
    private List<Product> productsp;
    private Customer customerp;

    public Order (Customer customer)
    {
        customerp = customer;
        productsp = new List<Product>();
    }


    public void AddProduct(Product product)
{
    productsp.Add(product);
}


public double GetTotalCost()
{
    double totalCost = 0;

    foreach(Product product in productsp)
    {
        totalCost += product.CalculateTotalCost();
    }

    totalCost += customerp.LivesInUsa() ? 5: 35;
    return totalCost;
}


public string GetPackingLabel()
{
    string label = "Packing Label:\n";
    foreach (Product product in productsp)
    {
        label += $" - {product.GetName()} - {product.GetProductId()}";
    }

    return label;

}

public string GetShippingLabel()
{
    string label = "Shipping Label: \n";
    label += customerp.GetCustomerInformation();
    return label;
}

}