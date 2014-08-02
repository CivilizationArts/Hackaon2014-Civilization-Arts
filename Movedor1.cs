using UnityEngine;
using System.Collections;

public class Movedor1 : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Debug.Log(gameObject.name);
		NotificationCenter.DefaultCenter().PostNotification(this,"Derecho");
	}
}
