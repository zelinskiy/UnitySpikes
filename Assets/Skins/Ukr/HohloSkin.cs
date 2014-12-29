using UnityEngine;
using System.Collections;

public class HohloSkin : MonoBehaviour {

	void OnMouseDown(){
		PlayerPrefs.SetInt ("Skin", 1);
		Application.LoadLevel ("Menu");
	}
}
