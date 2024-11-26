using UnityEngine;
using System.Collections;

public class ZzzLog : MonoBehaviour {
    uint qsize = 15;  // number of messages to keep
    Queue myLogQueue = new Queue();

    void Start() {
        Debug.Log("Pets in town. :D");
    }

    void OnEnable() {
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable() {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type) {
        myLogQueue.Enqueue("[message] : " + logString);
        if (type == LogType.Exception)
            myLogQueue.Enqueue(stackTrace);
        while (myLogQueue.Count > qsize)
            myLogQueue.Dequeue();
    }

    void OnGUI() {
        // Rectangle from 1/3 of screen width to 3/3 of screen width, and 100% of screen height
        GUILayout.BeginArea(new Rect(Screen.width / 3, 0, Screen.width / 3, Screen.height));
        // change font size
        _ = new GUIStyle(GUI.skin.textArea) {
            fontSize = 30
        };
        GUILayout.Label("\n" + string.Join("\n", myLogQueue.ToArray()));
        GUILayout.EndArea();
    }
}