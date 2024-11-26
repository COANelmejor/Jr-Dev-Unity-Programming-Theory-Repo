using System;
using UnityEngine;

public class GameController : MonoBehaviour {
    private Pet currentPet;

    private Pet[] pets = new Pet[] {
        new Cat(),
        new Dog(),
        new Bird()
    };

    void Start() {
        DataManager.Instance.Load();
        // Instantiate a pet (e.g., Cat)
        currentPet = pets[0];
        currentPet.PetType();
        currentPet.DisplayStatus();
    }

    void Update() {
        // Simple input handling to interact with the pet
        if (Input.GetKeyDown(KeyCode.F)) {
            currentPet.Feed();
            currentPet.DisplayStatus();
        } else if (Input.GetKeyDown(KeyCode.P)) {
            currentPet.Play();
            currentPet.DisplayStatus();
        } else if (Input.GetKeyDown(KeyCode.S)) {
            currentPet.Sleep();
            currentPet.DisplayStatus();
        } else if (Input.GetKeyDown(KeyCode.C)) {
            currentPet.PetType();
        } else if (Input.GetKeyDown(KeyCode.Tab)) {
            // Switch to the next pet
            currentPet = pets[(Array.IndexOf(pets, currentPet) + 1) % pets.Length];
            currentPet.PetType();
            currentPet.DisplayStatus();
        }
    }
}
