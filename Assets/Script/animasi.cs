using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasi : MonoBehaviour {
	private double countDown;

	public GameObject putih1,p2,p3;
	public GameObject ungu1,u2,u3; //u3 nanti merah
	public GameObject a1,a2,a3;
	public GameObject perintahIngatdanPilih;
	public GameObject pilihAngkadariTerkecil;
	public GameObject janganpilih;
	public GameObject tandasilang;
	public GameObject karenaAkan; //karena akan menyebabkan jalan yang dihubungkan untuk hewan lain, menjadi kembali ke hewan yang sama (jalan berputar). dan itu tidak diperbolehkan
	public GameObject jadi; //jadi, pemilihan jalan yang benar adalah seperti ini
	public GameObject benar;
	public GameObject tombolnext;
	// Use this for initialization
	void Start () {
		inisialisasi ();
	}
	
	// Update is called once per frame
	void Update () {
		countDown += Time.deltaTime;
		if (countDown >= 3) {
			perintahIngatdanPilih.SetActive (false);
			pilihAngkadariTerkecil.SetActive (true);
		}
		if (countDown >= 9) {
			pilihAngkadariTerkecil.SetActive (false);
			a1.SetActive (false);
			a2.SetActive (false);
			a3.SetActive (false);
			ungu1.SetActive (true);
		}
		if (countDown >= 10) {
			u2.SetActive (true);
		}
		if (countDown >= 12) {
			u3.SetActive (true);
			tandasilang.SetActive (true);
			janganpilih.SetActive (true);
		}
		if (countDown >= 14) {
			janganpilih.SetActive (false);
			karenaAkan.SetActive (true);
		}
		if (countDown >= 20) {
			u3.SetActive (false);
			tandasilang.SetActive (false);
			karenaAkan.SetActive (false);
			jadi.SetActive (true);
			benar.SetActive (true);
			tombolnext.SetActive (true);
		}
	}

	private void inisialisasi(){
		perintahIngatdanPilih.SetActive (true);
		putih1.SetActive (true);
		p2.SetActive (true);
		p3.SetActive (true);
		a1.SetActive (true);
		a2.SetActive (true);
		a3.SetActive (true);
		ungu1.SetActive (false);
		u2.SetActive (false);
		u3.SetActive (false);
		pilihAngkadariTerkecil.SetActive (false);
		janganpilih.SetActive (false);
		tandasilang.SetActive (false);
		karenaAkan.SetActive (false);
		jadi.SetActive (false);
		benar.SetActive (false);
		tombolnext.SetActive (false);
	}
}
