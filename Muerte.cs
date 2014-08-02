using UnityEngine;
using System.Collections;

public class Muerte : MonoBehaviour {
	private Animator animado;
	private GameObject MagoMuerte;
	public GameObject Reiniciar;
	// Use this for initialization
	void Start () {
		animado = GetComponent<Animator>();
		NotificationCenter.DefaultCenter().AddObserver(this,"Muerto");
	}
	void Muerto(Notification notificacion){
		animado.SetBool("Muerto",true);
		Reiniciar.SetActive(true);
	}
}
