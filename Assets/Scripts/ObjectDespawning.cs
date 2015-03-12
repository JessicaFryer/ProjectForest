using UnityEngine;
using System.Collections;

public class ObjectDespawning : MonoBehaviour {

	public GameObject[] environmentArray;
	//public GameObject treeObject;
	public int spawnRadius;
		

	// Use this for initialization
	void Start () {
		{
			environmentArray = GameObject.FindGameObjectsWithTag("Evironment");
		}
		foreach (GameObject environment in environmentArray)
		{
			environment.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKey(KeyCode.Q))
		{
			foreach (GameObject trees in treeArray)
			{
				trees.SetActive(false);
			}
		}
		else
		{
			foreach (GameObject trees in treeArray)
			{
				trees.SetActive(true);
			}
		}*/
		GetInactiveInRadius();
	}
	
	public void GetInactiveInRadius()
	{
		foreach (GameObject environment in environmentArray)
		{
			if(Vector3.Distance(transform.position,environment.transform.position) < spawnRadius)
			{
				environment.SetActive(true);
			}
			else
			{
				environment.SetActive(false);
			}
		}
	}
		
}
