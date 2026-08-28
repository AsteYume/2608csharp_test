namespace _2608test;

public interface ICanSale
{
    public bool IsThisSale {get; protected set;}
    public int SalePrice {get; protected set;}
    public void CalSalePrice();
}