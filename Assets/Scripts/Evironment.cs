using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TreeRandomRotation))]
public class Evironment : MonoBehaviour {

	// Use this for initialization
	void Start () {
		setCollider(false);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find("Player");
		float distance = Vector3.Distance (player.transform.position, gameObject.transform.position);
		if(distance < 10)
		{
			setCollider(true);
		}
		else
		{
			setCollider(false);
		}
	}
	
	public void setCollider(bool isColliderOn)
	{
		if(isColliderOn)
		{
			foreach(Collider c in GetComponents<Collider> ()) 
			{
				if(c.enabled == false)
				{
					c.enabled = true;
				}
			}
			//collider.enabled = true;
		}
		else
		{
			foreach(Collider c in GetComponents<Collider> ()) 
			{
				if(c.enabled == true)
				{
					c.enabled = false;
				}
			}
			//collider.enabled = false;
		}
	}
}
