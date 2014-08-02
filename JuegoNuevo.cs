using UnityEngine;
using System.Collections;

public class JuegoNuevo : MonoBehaviour {

	private Animator BotonJuego;	

	void Start() {
		BotonJuego = GetComponent<Animator>();
	}
	void OnMouseEnter(){
		BotonJuego.SetBool("MouseEnsima",true);
	}
	void OnMouseExit(){
		BotonJuego.SetBool("MouseEnsima",false);
	}
	void OnMouseDown(){
		Application.LoadLevel("escenaMago");
	}
}
