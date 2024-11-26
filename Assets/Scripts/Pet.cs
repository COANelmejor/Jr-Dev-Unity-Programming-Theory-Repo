using UnityEngine;

public abstract class Pet {
    // Encapsulated fields
    private int hungerLevel;
    private int happinessLevel;

    // Properties with getters and setters
    public int HungerLevel {
        get { return hungerLevel; }
        set { hungerLevel = Mathf.Clamp(value, 0, 100); }
    }

    public int HappinessLevel {
        get { return happinessLevel; }
        set { happinessLevel = Mathf.Clamp(value, 0, 100); }
    }

    // Constructor
    public Pet() {
        HungerLevel = 50;
        HappinessLevel = 50;
    }

    // Abstract methods to be overridden
    public abstract void PetType();
    public abstract void Feed();
    public abstract void Play();
    public abstract void Sleep();

    // Abstraction: Common method
    public void DisplayStatus() {
        Debug.Log($"Hunger: {HungerLevel}, Happiness: {HappinessLevel}");
    }
}
