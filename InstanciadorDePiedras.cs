using UnityEngine;
using System.Collections;

public class InstanciadorDePiedras : MonoBehaviour {
	public int nInstancias=0;
	public int velocidadDeGeneracion=2;
	private float tiempoDeGeneracion;
	public GameObject Bola;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Bola = GameObject.Find("piedra");
		if (Time.time > tiempoDeGeneracion) { 
			nInstancias += 1; 
			tiempoDeGeneracion = Time.time + velocidadDeGeneracion; 
			Invoke ("Disparador", 1f);
		} 
	
	}
	void Disparador(){
		Instantiate (Bola, transform.position,transform.rotation);
	}
}
