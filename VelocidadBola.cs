using UnityEngine;
using System.Collections;

public class VelocidadBola : MonoBehaviour {

//	private Transform BolaOscura;
//	public float Speed = 5f;
	public Transform Target;

	// Use this for initialization
	void Start () {
//		BolaOscura = GetComponent<Transform> ();
		Target = GameObject.Find ("Armature").transform;

	}
	
	// Update is called once per frame
	void Update () {
//		float VelocidadBola = -Speed * Time.deltaTime;
//		BolaOscura.Translate (VelocidadBola, 0, 0);
		GetComponent<NavMeshAgent> ().destination = Target.position;



	}
}
