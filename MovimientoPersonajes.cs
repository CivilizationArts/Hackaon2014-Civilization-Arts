using UnityEngine;
using System.Collections;

public class MovimientoPersonajes : MonoBehaviour {

	public bool Mago = false;
	public bool EnemigoMele = false;
	public bool EnemigoCaster = false;

	public Animator MagoAnimado;
	public Animator EnemigoMeleAnimado;
	public Animator EnemigoCasterAnimado;
	//private NavMeshAgent Mago;
	public GameObject CajaUnity;
	// Use this for initialization
	void Start () {
		MagoAnimado = GetComponent<Animator>();
		EnemigoMeleAnimado = GetComponent<Animator>();
		EnemigoCasterAnimado = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Mago){
			GetComponent<NavMeshAgent>().destination = CajaUnity.transform.position;
			MagoAnimado.SetBool("Corriendo",true);
		}
		if(EnemigoMele){
			GetComponent<NavMeshAgent>().destination = CajaUnity.transform.position;
			EnemigoMeleAnimado.SetBool("Accion1",true);
		}
		if(EnemigoCaster){
			//EnemigoCasterAnimado.SetBool("Accion",true);
		}
	
	}
}
