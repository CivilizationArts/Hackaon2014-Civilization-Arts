using UnityEngine;
using System.Collections;

public class Movedor2 : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Debug.Log(gameObject.name);
		NotificationCenter.DefaultCenter().PostNotification(this,"Izquierdo");
	}
}
