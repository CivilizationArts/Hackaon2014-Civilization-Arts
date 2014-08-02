using UnityEngine;
using System.Collections;

public class IAEnemigoCaster : MonoBehaviour {

	public Transform Mago;
	private Transform EnemigoCaster;

	public GameObject Bola;


	private int nInstancias=0;
	private int velocidadDeGeneracion=2;
	private float tiempoDeGeneracion;

	private float RangoMagiaActivada;
	// Use this for initialization
	void Start () {
		EnemigoCaster = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		RangoMagiaActivada = Mathf.Round (Vector3.Distance (EnemigoCaster.position, Mago.position));
		//Debug.Log (RangoMagiaActivada);
		if (RangoMagiaActivada <= 15) {
						if (Time.time > tiempoDeGeneracion) { 
								nInstancias += 1; 
								tiempoDeGeneracion = Time.time + velocidadDeGeneracion; 
								Invoke ("Disparador", 1f);
						} 
		} 
		if(RangoMagiaActivada>=15){
			CancelInvoke("Disparador");		
		}
	}
	void Disparador(){
		Instantiate (Bola, transform.position,transform.rotation);
	}
}
