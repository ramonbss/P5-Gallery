using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Management : MonoBehaviour {

	public bool isPaused  = false;

	private GameObject Player;
	public float min_distance = 7f;
	//public GameObject Scanning_Audio;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("GvrMain_with_Gaze");
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (Player.transform.position,transform.position);

		//Debug.Log ("distance: " + distance);

		if( distance < min_distance )
		{
			isPaused = false;
			if (!GetComponent<GvrAudioSource> ().isPlaying)
				Play ();
		}
		else{
			isPaused = true;
			if (GetComponent<GvrAudioSource> ().isPlaying)
				Pause ();
		}
	}

	private void Play()
	{
		GetComponent<GvrAudioSource> ().Play ();
	}

	private void Pause()
	{
		GetComponent<GvrAudioSource> ().Pause();
	}

}
