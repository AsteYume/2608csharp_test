namespace _2608test;

public interface ICanSale
{
    public bool isThisSale {get; protected set;}
    public int salePrice {get; protected set;}

    public void CalSalePrice();

}