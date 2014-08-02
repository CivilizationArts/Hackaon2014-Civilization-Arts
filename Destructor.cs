using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			NotificationCenter.DefaultCenter().PostNotification(this,"Muerto");
		}
	}
}
