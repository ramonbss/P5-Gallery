using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monitor_Slide : MonoBehaviour {

	public Texture[] slides;
	public string[] scripts;

	public Text Script;
	public RawImage Monitor;
	public Text txt_bookmark;

	public Text txt_Slide;

	private int index = 0;
	private int size_textures = 0;

	private GameObject Player;

	void Start()
	{
		Player = GameObject.Find ("GvrMain_with_Gaze");
		size_textures = slides.Length;
		ShowSlide ();
	}

	void Update()
	{
		float distance = Vector3.Distance (Player.transform.position,transform.position);

		//Debug.Log ("distance: " + distance);

		if( distance < 6 )
		{
			txt_Slide.raycastTarget = true;
		}
		else{
			txt_Slide.raycastTarget = false;
		}
	}

	public void onNext()
	{
		index = index + 1;

		if( index >= size_textures )
		{
			index = 0;
		}

		Debug.Log ("Index: " + index);

		ShowSlide ();

	}

	public void onPrevious()
	{
		index = index -1;

		if( index < 0 )
		{
			index = size_textures-1;
		}

		Debug.Log ("Index: " + index);

		ShowSlide ();

	}

	private void ShowSlide()
	{
		// Apply this texture to Monitor

		Monitor.texture = slides [index];						// Update Monitor's image
		Script.text = scripts[ index ];							// Update image text
		txt_bookmark.text = (index+1) + "/" + size_textures;	// Update bookmark

		/*
		//Monitor.GetComponent<Renderer> ().material.mainTexture = slides[ index ];
		//Monitor.GetComponent<Renderer> ().material.mainTexture = plane_image;
		//Monitor.mainTexture = slides[ index ];
		*/
	}


}
