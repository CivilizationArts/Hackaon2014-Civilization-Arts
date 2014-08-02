using UnityEngine;
using System.Collections;

public class Creditos : MonoBehaviour {

	private Animator BotonJuego;	
	
	void Start() {
		BotonJuego = GetComponent<Animator>();
	}
	void OnMouseEnter(){
		BotonJuego.SetBool("Accion",true);
	}
	void OnMouseExit(){
		BotonJuego.SetBool("Accion",false);
	}
	void OnMouseDown(){
		Application.LoadLevel("escenaCreditos");
	}
}
