using UnityEngine;
using System.Collections;

public class MoverSierra : MonoBehaviour {

	private Transform Sierra;
	public float Speed = 5f;
	public bool MovedorDeSierra=true;
	public bool ActivarCostados =true;
	// Use this for initialization
	void Start () {
		Sierra = GetComponent<Transform>();
		NotificationCenter.DefaultCenter().AddObserver(this,"Derecho");
		NotificationCenter.DefaultCenter().AddObserver(this,"Izquierdo");
	}
	void Derecho(Notification notificacion){
		MovedorDeSierra = false;
	}
	void Izquierdo(Notification notificacion){
		MovedorDeSierra = true;
	}
	
	// Update is called once per frame
	void Update () {
		//Sierra.Rotate(0,0,Speed * Time.deltaTime);
		if(ActivarCostados){
			if(MovedorDeSierra){
				Sierra.Translate(0,0,Speed * Time.deltaTime);
			}else{
				Sierra.Translate(0,0,-Speed * Time.deltaTime);
			}
		}else{
			if(MovedorDeSierra){
				Sierra.Translate(0,Speed * Time.deltaTime,0);
			}else{
				Sierra.Translate(0,-Speed * Time.deltaTime,0);
			}
		}



	}
}
