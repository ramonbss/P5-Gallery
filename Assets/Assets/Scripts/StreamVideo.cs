using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]
//[RequireComponent (typeof(GvrAudioSource))]

public class StreamVideo : MonoBehaviour {

	public MovieTexture movie;
	private AudioSource audio;
	//private GvrAudioSource audio;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		audio = GetComponent<AudioSource>();
		//audio = GetComponent<GvrAudioSource>();
		audio.clip = movie.audioClip;

		movie.Pause ();
		audio.Pause ();
	}
	
	// Update is called once per frame
	void Update () {

		/*
		if( Input.GetMouseButtonDown( 0 ) && movie.isPlaying )
		{
			movie.Pause ();
			audio.Pause ();
		}
		else if( Input.GetMouseButtonDown( 0 ) && !movie.isPlaying )
		{
			movie.Play ();
			audio.Play ();
		}
		*/

	}

	public void OnClick()
	{
		if( movie.isPlaying )
		{
			movie.Pause ();
			audio.Pause ();
		}
		else if( !movie.isPlaying )
		{
			movie.Play ();
			audio.Play ();
		}
	}

}
