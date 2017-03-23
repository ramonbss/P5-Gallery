using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_script : MonoBehaviour {

	private int screen_index = 0;

	public GameObject Panel1;
	public GameObject Panel2;


	public void update_screen()
	{
		if( screen_index == 0 )
		{
			Panel1.SetActive(false);
			Panel2.SetActive(true);
			screen_index++;
		}
		else if( screen_index == 1 )
		{
			Panel2.SetActive(false);
		}
	}

}
