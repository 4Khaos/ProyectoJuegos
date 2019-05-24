using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onTapPause() {

        // Here you define the screens to load/unload,
        // the relative path of your screen prefabs 
        // and the name of your canvas object
        string oldScreenName = "ScreenGame";
        string newScreenName = "ScreenPause";
        string canvasName = "Canvas";
        string pathToScreens = "UI/Screens/";

        // Destroy the current UI Screen
        GameObject oldScreen = GameObject.Find(canvasName + "/" + oldScreenName);
        Destroy(oldScreen);

        // Get a reference to canvas object
        GameObject canvas = GameObject.Find(canvasName);

        // Creates a copy of the new UI Screen
        GameObject newScreen = Instantiate(Resources.Load(pathToScreens + newScreenName) as GameObject);
        newScreen.SetActive(true);
        newScreen.name = newScreenName;

        // Make the new screen child of canvas object
        newScreen.transform.SetParent(canvas.transform);

        // Reset new screen's transform
        newScreen.transform.rotation = Quaternion.identity;
        newScreen.transform.position = Vector3.zero;
        newScreen.transform.localScale = Vector3.one;

        // Locate anchors on screen's corners
        newScreen.GetComponent<RectTransform>().anchorMin = Vector2.zero;
        newScreen.GetComponent<RectTransform>().anchorMax = Vector2.one;

        // Move vertices to anchor's position
        newScreen.GetComponent<RectTransform>().offsetMin = Vector2.zero;
        newScreen.GetComponent<RectTransform>().offsetMax = Vector2.zero;
    }
}
