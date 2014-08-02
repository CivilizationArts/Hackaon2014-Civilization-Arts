using UnityEngine;
using System.Collections;

public class MovimientoMagico : MonoBehaviour {
	public GameObject Antorcha;
	private Animator MagoAnimado;
	private CharacterController ControladorPersonaje;
	private Transform TransformMago;
	public GameObject Halo;
	public float Speed = 6f;
	public float FuerzaDeSalto = 8f;
	public float Gravedad = 20f;
	public bool DetectorSuelo = true;
	public bool Salto = true;
	public int Contador = 0;
	public float rotationSpeed = 100.0F;
	private float Rotar;
	private Vector3 DireccionMovimiento = Vector3.zero;
	private bool ActivadorMovimiento = true;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this,"AgarroAntorcha");
		ControladorPersonaje = GetComponent<CharacterController> ();
		TransformMago = GetComponent<Transform> ();
		MagoAnimado = GetComponent<Animator> ();
		NotificationCenter.DefaultCenter ().AddObserver (this, "ClickEnCaja");
		NotificationCenter.DefaultCenter ().AddObserver (this, "NoClickEnCaja");
	}
	void AgarroAntorcha(Notification notificaion){
		Antorcha = GameObject.Find("antorcha PEQUEÑA");
		Destroy(Antorcha);
	}
	void ClickEnCaja(Notification notificacion){
		ActivadorMovimiento = false;
		MagoAnimado.SetBool("Atacando",true);
		Halo.SetActive (true);
	}
	void NoClickEnCaja(Notification notificacion){
		ActivadorMovimiento = true;
		MagoAnimado.SetBool("Atacando",false);
		Halo.SetActive (false);
	}
	void Update () {
		if (ControladorPersonaje.isGrounded) {
			DireccionMovimiento = new Vector3 (0,0,Input.GetAxis ("Vertical"));	
			DireccionMovimiento = transform.TransformDirection (DireccionMovimiento);
			DireccionMovimiento *= Speed;
			Contador=0;
			Salto=true;
			MagoAnimado.SetBool("Saltando",false);
		}
		Rotar = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		if(Input.GetButtonDown("Jump") && Salto){
			DireccionMovimiento =new Vector3(DireccionMovimiento.x,FuerzaDeSalto,DireccionMovimiento.z);
			Contador++;
			MagoAnimado.SetBool("Saltando",true);
		}
		if (Contador == 2) {
			Salto=false;		
		}
		DireccionMovimiento.y -= Gravedad * Time.deltaTime;
		if (ActivadorMovimiento) {
			ControladorPersonaje.Move (DireccionMovimiento * Time.deltaTime);
		}
		TransformMago.Rotate (0, Rotar,0 );
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.D)) {
			MagoAnimado.SetBool("Corriendo",true);		
		}
		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.D)) {
			MagoAnimado.SetBool("Corriendo",false);		
		}
	}
	void OnMouseDown(){
		if (gameObject.tag == "Player") {
			NotificationCenter.DefaultCenter().PostNotification(this,"ClickEnPlayer");		
		}
	}
}
