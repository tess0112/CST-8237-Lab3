using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeButtonText : MonoBehaviour {

    public Text textToChange;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeText(string newText)
    {
        textToChange.text = newText;
    }
}
