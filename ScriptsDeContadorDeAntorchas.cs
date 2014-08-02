using UnityEngine;
using System.Collections;

public class ScriptsDeContadorDeAntorchas : MonoBehaviour {
	public TextMesh Marcador;
	private int Contador =0;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this,"AgarroAntorcha");

	}
	void AgarroAntorcha(Notification notificacion){
		Contador++;
	}
	
	// Update is called once per frame
	void Update () {
		Marcador.text = "10/" + Contador; 
	}
}
