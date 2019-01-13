using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void PanelButton()
    {
        print("Panel Button Pressed");
    }

    private void OnMouseDown()
    {
        print("Touched");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
