 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {
	private GameObject vButtonObject;
	private GameObject zombie;
	// Use this for initialization
	void Start () {
		vButtonObject = GameObject.Find ("actionButton");
		zombie = GameObject.Find ("zombie");

		vButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

	}
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){

		Debug.Log ("Button down !!");
		zombie.GetComponent<Animation> ().Play ();

	
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		zombie.GetComponent<Animation> ().Stop ();

	}
}
