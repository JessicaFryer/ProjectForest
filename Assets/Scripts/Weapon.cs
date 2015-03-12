using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Physics.IgnoreCollision(transform.collider,collider);
		collider.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		
		/*if (gameObject.CompareTag == "object")
		{
			//Debug.Log ("Made contact");
		}*/
		
	}
}
