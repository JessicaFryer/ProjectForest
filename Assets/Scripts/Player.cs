﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    //Player
    public int health;
    public string name;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void FixedUpdate() 
	{
		checkPlayerControls();
	}

    public void checkPlayerControls()
    {
		//Check if moving
		/*if (Input.GetKey(forwardKey))
		{
			isWalking = true;
		}
		else if (Input.GetKey(backKey))
		{
			isWalking = true;
		}
		else
		{
			isWalking = false;
		}
		
    	//Move
		if (Input.GetKey(leftKey))
		{
			rotate(Vector3.down,isWalking);
		}
		if (Input.GetKey(rightKey))
		{
			rotate(Vector3.up,isWalking);
		}
        if (Input.GetKey(forwardKey))
        {
            move(Vector3.forward);
        }
        if (Input.GetKey(backKey))
        {
            move(Vector3.back);
        }
        if (Input.GetKeyDown(jumpKey))
        {
            jump();
        }*/
		
		//Attack
		/*if (Input.GetKey(attackKey))
		{
			
		}*/
    }
    
    /*public void treeColliderCheck ()
    {
		Collider[] trees = Physics.OverlapSphere(gameObject.transform.position,10);
		
		for(int i = 0; i < trees.Length; i++)
		{
			float distance = Vector3.Distance (gameObject.transform.position, trees[i].transform.position);
			if(trees[i].tag == "Tree" && distance < 10 )
			{

				trees[i].collider.enabled = true;
			}
			else if(trees[i].tag == "Tree")
			{
				trees[i].collider.enabled = false;
			}
		}
    }*/
}
