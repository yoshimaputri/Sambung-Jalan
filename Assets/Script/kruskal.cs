using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kruskal : MonoBehaviour {

	public int[,] graf;
	private int inde;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public ArrayList krusk(int [,] graph, int [] bobot){
		int panjang, a, indexminim;
		panjang = graph.Length;
		ArrayList jawab = new ArrayList();
		for(a=0;a<panjang;a++){
			jawab.Add(0);
		}
		for(a=0;a<panjang;a++){
			indexminim = findminim(bobot);
			jawab[indexminim] = 1;
			bool cek = cycle(graph, jawab, indexminim);
			if(cek == false){
				bobot[indexminim] = 100;
			}
			else if (cek == true){
				jawab[indexminim] = 0;
				bobot[indexminim] = 100;
			}
		}
		return jawab;
	}

	public int findminim(int [] bobot){
		int minim = 1000000, a;
		for (a = 0; a < bobot.Length; a++) {
			if (bobot [a] < minim) {
				minim = bobot [a];
				inde = a;
			}
		}
		return inde;
	}	

	private bool cycle(int [,] graph, ArrayList ongraph, int select){
		ArrayList index = new ArrayList ();
		ArrayList net = new ArrayList ();
		Debug.Log (select);
		index = two (graph, getRow(graph, select));
		int a, mark, i, b, c;
		for (a = 0; a < index.Count; a++) {
			mark = index.IndexOf(a);
			ArrayList check = new ArrayList ();
			for (i = 0; i < ongraph.Count; i++) {
				check.Add (0);
			}
			check [select] = 1;
			int marker = 0;
			if (ongraph.IndexOf(mark) == 1) {
				b = mark;
				while (true) {
					net = two (graph, getRow(graph,b));
					check [b] = 1;
					int temp = b;
					for (c = 0; c < net.Count; c++) {
						int variable = net.IndexOf(c);
						if (check.IndexOf(variable) == 1) {
							if (getRow(graph, variable) == getRow(graph, select)) {
								marker += 1;
							}
						}
						else if (check.IndexOf(variable) == 0) {
							if (ongraph.IndexOf(c) == 1) {
								b = c;
							}
						}
					}
					if (marker == 2) {
						return true;
					} else if (temp == b) {
						break;
					}
				}
			}
		}
		return false;
	}

	private ArrayList two(int [,] graph, int [] cari){
		int[] cek;
		ArrayList dan = new ArrayList ();
		int a, b, c;
		for (a = 0; a < cari.Length; a++) {
			if (cari [a] == 1) {
				for (b = 0; b < graph.Length; b++) {
					cek = getRow(graph, b);
					if (cek != cari) {
						for (c = 0; c < cari.Length; c++) {
							if (cek [c] == 1) {
								dan.Add (b);
							}
						}
					}
				}
			}	
		}
		return dan;
	}

	private int[] getRow(int [,] first, int index){
		int[] row = new int[first.GetLength (1)];
		int panjang = first.GetLength (1), a;
		for (a = 0; a < panjang; a++) {
			row [a] = first [index,a];
		}
		return row;
	}
}