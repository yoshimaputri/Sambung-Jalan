using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitscript : MonoBehaviour {
	// Use this for initialization
	public void quitGame () {
		Debug.Log ("close game");
		Application.Quit ();
	}
}
