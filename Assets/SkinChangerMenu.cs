using UnityEngine;
using System.Collections;

public class SkinChangerMenu : MonoBehaviour {

	public Sprite Hohol_Player;
	public Sprite Sovok_Player;
	public Sprite Imp_Player;
		
	void Start () {
		int ss = PlayerPrefs.GetInt ("Skin");
		
		
		if (ss == 1) {
			GetComponent<SpriteRenderer>().sprite = Hohol_Player;
		}
		else if (ss == 2) {
			GetComponent<SpriteRenderer>().sprite = Sovok_Player;
		}
		else if (ss == 3) {
			GetComponent<SpriteRenderer>().sprite = Imp_Player;
		}
	}
}
