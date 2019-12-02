using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonFire : MonoBehaviour, IVirtualButtonEventHandler {
    private GameObject vbButton1;
	// Use this for initialization
	void Start () {
        vbButton1 = GameObject.Find("FireButton");
        vbButton1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	
    public void OnButtonPressed(VirtualButtonBehaviour vr)
    {
        CharacterController.isFire = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vr)
    {
        CharacterController.isFire = false;
    }
}
