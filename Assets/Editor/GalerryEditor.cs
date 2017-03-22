using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Editor_Tools))]
//public class GalerryEditor : MonoBehaviour {
public class GalerryEditor : Editor {

	public override void OnInspectorGUI()
	{
		// Draw default inspector
		DrawDefaultInspector ();

		Editor_Tools myEditor = (Editor_Tools)target;

		// How to add an element and get it updated value
		//myEditor.lvl_value = EditorGUILayout.IntField ("Experience", myEditor.lvl_value);

		if( GUILayout.Button("Match_X") )
		{
			myEditor.Match_X ( myEditor.Reference, myEditor.Target );
		}
		else if( GUILayout.Button("Match_Y") )
		{
			myEditor.Match_Y ( myEditor.Reference, myEditor.Target );
		}
		else if( GUILayout.Button("Match_Z") )
		{
			myEditor.Match_Z ( myEditor.Reference, myEditor.Target );
		}
		else if( GUILayout.Button("Match") )
		{
			myEditor.Match_Objects ( myEditor.Reference, myEditor.Target );
		}

	}
}
