using UnityEngine;

public class FruitSalad_ : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Creating the fruit");
        Fruit_ myFruit = new();
        Debug.Log("Creating the apple");
        Apple_ myApple = new();

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();

        Debug.Log("Creating the fruit");
        myFruit = new Fruit_("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple_("green");

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();
    }
}