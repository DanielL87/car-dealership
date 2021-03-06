using System;
namespace Dealership {

class Car
{
  private string MakeModel;
  private int Price;
  private int Miles;
  private string Description;

  public Car(string makeModel, int price, int miles, string description)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Description = description;
  }
    public void SetPrice(int newPrice)
  {
    Price = newPrice;
  }

  public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetDescription()
    {
      return Description;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return ((Price < maxPrice) && (Miles < maxMiles));
    }
  }

}
