using UnityEngine;
using System.Collections;

public class CogerCajas : MonoBehaviour {

	private Transform Caja;
	void Start () {


		Caja = GetComponent<Transform> ();

	}
	
	void Update () {
		Caja.position = new Vector3(Caja.position.x,Caja.position.y,0);
	}

	void OnMouseDown(){
		if (gameObject.name == "Caja") {
			NotificationCenter.DefaultCenter().PostNotification(this,"ClickEnCaja");		
		}
	}
	void OnMouseUp(){
		if (gameObject.name == "Caja") {
			NotificationCenter.DefaultCenter().PostNotification(this,"NoClickEnCaja");		
		}
	}

}












