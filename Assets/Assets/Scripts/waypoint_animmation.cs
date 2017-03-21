using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waypoint_animmation : MonoBehaviour {

	public GameObject particles;
	public GameObject player;
	public GameObject Panel_Msg;
	public string waypoint_title;

	void onStart()
	{
		Panel_Msg.GetComponentInChildren<Text> ().text = waypoint_title;
		//player_msgs.text = waypoint_title;
	}

	void Update()
	{
		/*
		if (title_canvas.isActiveAndEnabled) {
			//y_translation = Mathf.Sin (Time.time) * 2;
			float y_pos = y_translation + Mathf.Sin (Time.time)/2;
			title_canvas.transform.position = new Vector3( title_canvas.transform.position.x, y_pos, title_canvas.transform.position.z );
			//title_canvas.transform.rotation = y_rotation;
			title_canvas.transform.LookAt( player.transform.position );
		}
		*/
	}

	public void OnEnter()
	{
		Debug.Log ("OnEnter");
		particles.SetActive (true);
		//player_msgs.text = waypoint_title;
		//player_msgs.gameObject.SetActive(true);
		Panel_Msg.GetComponentInChildren<Text> ().text = waypoint_title;
		Panel_Msg.SetActive(true);
		//title_canvas.enabled = true;
	}

	public void OnExit()
	{
		Panel_Msg.SetActive(false);
		//player_msgs.gameObject.SetActive(false);
		particles.SetActive (false);
		//title_canvas.enabled = false;
	}

}
