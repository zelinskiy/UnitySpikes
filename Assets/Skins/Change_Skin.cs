using UnityEngine;
using System.Collections;

public class Change_Skin : MonoBehaviour {

	void OnMouseDown(){
		PlayerPrefs.SetInt ("Skin", 0);
		Application.LoadLevel ("Menu");
	}
}
