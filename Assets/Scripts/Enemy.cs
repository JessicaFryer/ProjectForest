using UnityEngine;
using System.Collections;

[System.Serializable]
public struct Properties
{
	public string name;
	public int health;
	public float speed;
	public int attack;
	public float agroRadios;
}


public class Enemy : MonoBehaviour {
	public Properties properties;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(properties.health <= 0)
		{
			Destroy (gameObject);
		}
	}
	
}
