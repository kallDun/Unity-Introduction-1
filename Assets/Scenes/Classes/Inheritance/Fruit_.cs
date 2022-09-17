using UnityEngine;

public class Fruit_
{
    public string color;

    public Fruit_()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    public Fruit_(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}