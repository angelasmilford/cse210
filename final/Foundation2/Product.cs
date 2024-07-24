public class Product
{
    private string _name;
    private string _id;
    private float _productPrice;
    private float _totalPrice;
    private int _quantity;

    public Product(string name, string id, float productPrice, int quantity)
    {
        _name = name;
        _id = id;
        _productPrice = productPrice;
        _quantity = quantity;
        CalculateTotalPrice();
    }
    private void CalculateTotalPrice()
    {
        _totalPrice = _productPrice * _quantity;
    }

    //GETTERS
    public string GetProductName()
    {
        return _name;
    }
    public string GetID()
    {
        return _id;
    }
    public float GetProductPrice()
    {
        return _productPrice;
    }
    public float GetTotalPrice()
    {
        return _totalPrice;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

}