using UnityEngine;
using System.Collections;

public class IAEnemigo : MonoBehaviour {

	private Transform Enemigo;
	public Transform Mago;
	private CharacterController ControlEnemigo;
	private Vector3 DireccionMovimiento= Vector3.zero;
	public float DistanciaDePatrulla=3f;
	public float Speed = 5f;
	public float Gravedad = 20f;
	public float SpeedRotacion = 5f;
	//private float Rotacion=0f;
	private bool TiempoDeCambio=true;
	public bool ActivarRotacion0 = true;
	public bool ActivarRotacion180 = true;
	public bool DesactiuvarMovimiento=true;
	public float PosicionEnemigo;

	private float DistanciaDeVision; 
	// Use this for initialization
	void Start () {
		Enemigo = GetComponent<Transform> ();
		ControlEnemigo = GetComponent<CharacterController> ();
		PosicionEnemigo = Enemigo.position.x;
		GetComponent<VelocidadBola> ().enabled = false;
		GetComponent<NavMeshAgent> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		DistanciaDeVision = Mathf.Round (Vector3.Distance (Enemigo.position, Mago.position));
		Debug.Log (DistanciaDeVision);
		if (DistanciaDeVision >= 5f) {
			PatrullaEnemigo ();
		}
		if (DistanciaDeVision <= 5f) {
			GetComponent<VelocidadBola> ().enabled = true;
			GetComponent<NavMeshAgent> ().enabled = true;
		}
	}

	void PatrullaEnemigo(){
		float PosxEnemigo = Enemigo.position.x;
		if(PosxEnemigo>=(PosicionEnemigo+DistanciaDePatrulla)){
			if(ActivarRotacion180){
				DesactiuvarMovimiento=false;
				Enemigo.eulerAngles = new Vector3 (0,180,0);
				Debug.Log(Enemigo.rotation.y);
				if(Enemigo.rotation.y >= 0.5){
					ActivarRotacion180=false;
				}
			}else{
				DesactiuvarMovimiento=true;
			}
			ActivarRotacion0 = true;
		}
		if(PosxEnemigo<=(PosicionEnemigo-DistanciaDePatrulla)){
			if(ActivarRotacion0){
				DesactiuvarMovimiento=false;
				Enemigo.eulerAngles = new Vector3 (0,0,0);
				Debug.Log(Enemigo.rotation.y);
				if(Enemigo.rotation.y == 0){
					ActivarRotacion0=false;
				}
			}else{
				DesactiuvarMovimiento=true;
			}
			ActivarRotacion180 = true;
		}
		if (ControlEnemigo.isGrounded) {
			if(TiempoDeCambio){
				DireccionMovimiento = new Vector3 (5,0,0);	
				DireccionMovimiento = transform.TransformDirection (DireccionMovimiento);
				DireccionMovimiento *= Speed;
			}
		}
		DireccionMovimiento.y -= Gravedad * Time.deltaTime;
		if (DesactiuvarMovimiento) {
			ControlEnemigo.Move (DireccionMovimiento * Time.deltaTime);
		}
	}
}
	
