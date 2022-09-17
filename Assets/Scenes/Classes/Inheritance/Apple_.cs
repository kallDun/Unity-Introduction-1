using UnityEngine;

public class Apple_ : Fruit_
{
    public Apple_()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }
    public Apple_(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
}