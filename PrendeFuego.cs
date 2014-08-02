using UnityEngine;
using System.Collections;

public class PrendeFuego : MonoBehaviour {
	public GameObject Flama;
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			Flama.SetActive(true);
		}
	}
}
