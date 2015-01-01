using UnityEngine;
using System.Collections;

public class Change_skin_sovok : MonoBehaviour {

	void OnMouseDown(){
		PlayerPrefs.SetInt ("Skin", 2);
		Application.LoadLevel ("Menu");
	}
}
