using UnityEngine;

public class Dog : Pet {
    public override void Feed() {
        HungerLevel -= 15;
        Debug.Log("The dog is eating bones.");
    }

    public override void Play() {
        HappinessLevel += 20;
        Debug.Log("The dog is playing fetch.");
    }

    public override void Sleep() {
        HungerLevel += 10;
        Debug.Log("The dog is sleeping.");
    }
}
