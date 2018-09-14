using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogDisplayer : MonoBehaviour {
    private Text textComponent;
	// Use this for initialization
	void Awake () {
        textComponent = gameObject.GetComponentInChildren<Text>();
	}

    public void SetDialogText(string newDialogText)
    {
        textComponent.text = newDialogText;
    }
	
	// Update is called once per frame
	public void CloseDialog ()
    {
        Destroy(gameObject);
	}
}
