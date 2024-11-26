using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI catNameInput;
    [SerializeField]
    private TextMeshProUGUI dogNameInput;
    [SerializeField]
    private TextMeshProUGUI birdNameInput;
    private void Start() { 
        catNameInput.text = DataManager.Instance.CatName;
        dogNameInput.text = DataManager.Instance.DogName;
        birdNameInput.text = DataManager.Instance.BirdName;
    }
    public void LoadGame() {

        // Save the names
        DataManager.Instance.CatName = catNameInput.text;
        DataManager.Instance.DogName = dogNameInput.text;
        DataManager.Instance.BirdName = birdNameInput.text;

        DataManager.Instance.Save();
        SceneManager.LoadScene("Main");
    }
}
