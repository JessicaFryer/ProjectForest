using UnityEngine;
using System.Collections;

public class TreeRandomRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		FixedUpdate();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.G))
		{
			Quaternion ran = Random.rotation;
			ran.x = transform.rotation.x;
			ran.z = transform.rotation.z;
			transform.rotation = ran;
		}
	}
}
