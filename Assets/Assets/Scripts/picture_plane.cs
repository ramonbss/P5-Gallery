using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class picture_plane : MonoBehaviour {

	public Text Script;
	public GameObject Monitor;
	public string Script_Msg;

	//public void onClick( Texture plane_image )
	public void onClick()
	{
		// Get texture from its GameObject
		Texture tex = gameObject.GetComponent<Renderer>().material.mainTexture;
		// Apply this texture to Monitor
		Monitor.GetComponent<Renderer> ().material.mainTexture = tex;
		//Monitor.GetComponent<Renderer> ().material.mainTexture = plane_image;
		Script.text = Script_Msg;
	}
}
