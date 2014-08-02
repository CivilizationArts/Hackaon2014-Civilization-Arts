using UnityEngine;
using System.Collections;

public class Salir : MonoBehaviour {

	private Animator BotonJuego;	
	
	void Start() {
		BotonJuego = GetComponent<Animator>();
	}
	void OnMouseEnter(){
		BotonJuego.SetBool("Accion1",true);
	}
	void OnMouseExit(){
		BotonJuego.SetBool("Accion1",false);
	}
	void OnMouseDown(){
		Application.Quit();
	}
}
