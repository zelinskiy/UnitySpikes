using UnityEngine;
using System.Collections;

public class MainMenuButton : MonoBehaviour {

	void OnMouseDown(){
		Application.LoadLevel ("Menu");
		print ("Toplel");
	}
}
