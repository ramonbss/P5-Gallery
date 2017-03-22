using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Editor_Tools : MonoBehaviour {

	public int lvl_value = 10;
	public GameObject Reference, Target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Match_Objects( GameObject obj1,GameObject obj2)
	{
		// Only works with object with renderer
		Vector3 sizeCalculated = obj1.GetComponent<Renderer> ().bounds.size;
		//Vector3 sizeCalculated = Vector3.Scale( obj1.transform.localScale, obj1.GetComponent<Mesh>().bounds.size);
		//obj2.transform.localScale = sizeCalculated;
		obj2.transform.localScale = Vector3.Scale( obj1.transform.localScale, sizeCalculated);

	}


	public void Match_Objects( GameObject obj1,GameObject obj2, bool match_x = true, bool match_y = true ,bool match_z = true)
	{
		if( match_x )
		{
			this.Match_X ( obj1, obj2 );
		}

		if( match_y )
		{
			this.Match_Y ( obj1, obj2 );
		}

		if( match_z )
		{
			this.Match_Z ( obj1, obj2 );
		}
		
	}

	public void Match_X( GameObject obj1,GameObject obj2 )
	{
		Vector3 sizeCalculated = obj1.GetComponent<Renderer> ().bounds.size;
		obj2.transform.localScale.Set( sizeCalculated.x, obj2.transform.localScale.y, obj2.transform.localScale.z );
		
	}

	public void Match_Y( GameObject obj1,GameObject obj2 )
	{
		Vector3 sizeCalculated = obj1.GetComponent<Renderer> ().bounds.size;
		obj2.transform.localScale.Set( obj2.transform.localScale.x, sizeCalculated.y,obj2.transform.localScale.z );
	}

	public void Match_Z( GameObject obj1,GameObject obj2 )
	{
		Vector3 sizeCalculated = obj1.GetComponent<Renderer> ().bounds.size;
		//obj2.transform.localScale.z = sizeCalculated.z;
		obj2.transform.localScale.Set( obj2.transform.localScale.x, obj2.transform.localScale.y, sizeCalculated.z );
	}

}
