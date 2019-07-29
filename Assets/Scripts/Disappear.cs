using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour {

public GameObject Wallbye;
public GameObject Wallbye2;
public int valided;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		valided= PlayerController.valide;
		if (valided == 4) {
			Wallbye.SetActive(false);
		}
		if (valided == 5) {
			Wallbye2.SetActive(false);
		}
	}
}
