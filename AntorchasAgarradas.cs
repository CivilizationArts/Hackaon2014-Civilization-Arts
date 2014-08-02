using UnityEngine;
using System.Collections;

public class AntorchasAgarradas : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			NotificationCenter.DefaultCenter().PostNotification(this,"AgarroAntorcha");
			Destroy(gameObject);
		}

	}
}
