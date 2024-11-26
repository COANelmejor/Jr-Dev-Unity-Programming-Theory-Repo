using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    private string m_catName;
    private string m_dogName;
    private string m_birdName;

    public string CatName { 
        get { return m_catName; }
        set { m_catName = value; }
    }
    public string DogName {
        get { return m_dogName; }
        set { m_dogName = value; }
    }
    public string BirdName {
        get { return m_birdName; }
        set { m_birdName = value; }
    }

    private void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData {
        public string catName;
        public string dogName;
        public string birdName;
    }

    public void Save() {
        SaveData data = new() {
            catName = m_catName,
            dogName = m_dogName,
            birdName = m_birdName
        };
        string json = JsonUtility.ToJson(data);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Load() {
        string path = Application.persistentDataPath + "/savefile.json";
        if (System.IO.File.Exists(path)) {
            string json = System.IO.File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            m_catName = data.catName;
            m_dogName = data.dogName;
            m_birdName = data.birdName;
        }
    }

}
