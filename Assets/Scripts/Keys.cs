using UnityEngine;
using System.Collections;

public struct MovementDirection 
{
	public bool up;
	public bool down;
	public bool left;
	public bool right;
}

public class Keys : MonoBehaviour {

	private float horizontalDirection = Input.GetAxis ("Horizontal");
	private float verticalDirection = Input.GetAxis ("Vertical");
	
	MovementDirection mDirection = new MovementDirection();
	
	/*public bool mUp = false;
	public bool mDown = false;
	public bool mLeft = false;
	public bool mRight = false;*/

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(horizontalDirection > 0){ mDirection.right = true;  }
		else                       { mDirection.right = false; }
		
		if(horizontalDirection < 0){ mDirection.left = true;  }
		else                       { mDirection.left = false; }
		
		if(verticalDirection > 0)  { mDirection.up = true;  }
		else                       { mDirection.up = false; }
		
		if(verticalDirection < 0)  { mDirection.down = true;  }
		else                       { mDirection.down = false; }
	}
	
	public string getDirectionString ()
	{
		if(mDirection.right)
		{
			if(mDirection.up)
			{
				return "Top Right";
			}
			else if(mDirection.down)
			{
				return "Bottom Right";
			}
			else
			{
				return "Right";
			}
		}
		else if(mDirection.left)
		{
			if(mDirection.up)
			{
				return "Top Left";
			}
			else if(mDirection.down)
			{
				return "Bottom Left";
			}
			else
			{
				return "Left";
			}
		}
		else
		{
			return "Standing still";
		}
	}
	
}
