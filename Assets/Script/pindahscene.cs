using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahscene : MonoBehaviour {

	public string namaScene;

	// Use this for initialization
	public void pindahScene () {
		Debug.Log ("keklik");
		SceneManager.LoadScene (namaScene);

		Debug.Log (namaScene);
	}
}
