using UnityEngine;
using System.Collections;

public class SkinChangerMenu : MonoBehaviour {

	public Sprite Hohol_Player;

		
	void Start () {
		int ss = PlayerPrefs.GetInt ("Skin");
		
		
		if (ss == 1) {
			GetComponent<SpriteRenderer>().sprite = Hohol_Player;
		}
	}
}
