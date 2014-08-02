using UnityEngine;
using System.Collections;

public class CamaraPlataforma : MonoBehaviour {

	public Transform Personaje;
	public int EspacioDeCamara=3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Personaje.position.x+EspacioDeCamara, transform.position.y, transform.position.z);

	}
}
