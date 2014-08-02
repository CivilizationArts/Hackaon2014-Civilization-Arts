using UnityEngine;
using System.Collections;

public class RangoDeMagia : MonoBehaviour {
	private Transform Mago;
	public GameObject Box;
	private float Distance;
	void Start(){
		Mago = GetComponent<Transform> ();
	}
	void Update () {
		Box = GameObject.Find("Caja");
		Distance = Mathf.Round ( Vector3.Distance (Mago.position, Box.transform.position) );
		//GetComponent <TextMesh>().text = Distance.ToString () + " mts";
		if (Distance <= 5){
			NotificationCenter.DefaultCenter().PostNotification(this,"MagiaActivada");
		}
		if (Distance >= 5) {
			NotificationCenter.DefaultCenter().PostNotification(this,"MagiaDesactivada");
		}
	}


}
