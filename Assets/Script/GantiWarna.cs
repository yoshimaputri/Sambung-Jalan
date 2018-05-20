using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GantiWarna : MonoBehaviour {

	public GameObject nyala;
	public GameObject mati;
	public GameObject angka;
	public GameObject button;
	[SerializeField]
	private double countDown;
	[SerializeField]
	private double matiAngka;
	public bool isActive;
	[SerializeField]
	private bool kunci;


	// Use this for initialization
	void Start () {
		matiAngka = 10;
		isActive = false;
		MulaiMain ();
	}
	
	// Update is called once per frame
	void Update () {
		countDown += Time.deltaTime;
		if (countDown >= matiAngka)
		{
			MatiinAngka ();
		}
	}

	private void MulaiMain()
	{
		angka.SetActive(true);
		mati.SetActive(true);
		nyala.SetActive(false);
	}

	private void MatiinAngka()
	{
		angka.SetActive (false);
		button.SetActive (true);
	}

	public void GantiValue()
	{
		if (isActive) {
			mati.SetActive (true);
			nyala.SetActive (false);
			isActive = false;
		} else {
			mati.SetActive (false);
			nyala.SetActive (true);
			isActive = true;
		}
		//Debug.Log ("terpencet");
	}
}
