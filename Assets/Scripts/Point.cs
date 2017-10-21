using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Point : MonoBehaviour
{
	MeshRenderer mr;

	void Start ()
	{
		mr = GetComponent<MeshRenderer> ();
	}

	public void Click()
	{
		Game.player.transform.position = new Vector3(Game.player.transform.position.x, Game.player.transform.position.y, transform.position.z);
	}

	public void MouseHover(bool enter)
	{
		if (enter)
		{
			//mr.material = Hover;
			transform.localScale = new Vector3(.7f, .7f, .7f);
		}
		else
		{
			//mr.material = Normal;
			transform.localScale = new Vector3(.5f, .5f, .5f);
		}
	}
}
