using UnityEngine;
public class Cat : Pet {

    public override void PetType() {
        Debug.Log("Hello cat");
    }
    public override void Feed() {
        HungerLevel -= 10;
        Debug.Log("The cat is eating fish.");
    }

    public override void Play() {
        HappinessLevel += 15;
        Debug.Log("The cat is playing with a ball of yarn.");
    }

    public override void Sleep() {
        HungerLevel += 5;
        Debug.Log("The cat is napping.");
    }
}