using UnityEngine;
using System.Collections;

public class Skin_Set_Imp : MonoBehaviour {

	void OnMouseDown(){
		PlayerPrefs.SetInt ("Skin", 3);
		Application.LoadLevel ("Menu");
	}
}
