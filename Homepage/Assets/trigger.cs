using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class trigger : MonoBehaviour {

	public Text txt;

	private bool productCounted = false;
	private int productCounter = 0;

	// Use this for initialization
	void Start () {
		txt.text = "Products in cart:" + productCounter;
	}

	void Update() {
		if (productCounted) {
			txt.text = "Products in cart:" + productCounter;
			productCounted = false;
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Product") {
			productCounter++;
			productCounted = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Product") {
			productCounter--;
			productCounted = true;
		}
	}
}