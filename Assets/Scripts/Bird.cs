using UnityEngine;

public class Bird : Pet {
    public override void Feed() {
        HungerLevel -= 5;
        Debug.Log("The bird is eating seeds.");
    }

    public override void Play() {
        HappinessLevel += 10;
        Debug.Log("The bird is singing.");
    }

    public override void Sleep() {
        HungerLevel += 2;
        Debug.Log("The bird is resting.");
    }
}