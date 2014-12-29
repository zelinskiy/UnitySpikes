using UnityEngine;
using System.Collections;

public class Skin_changer : MonoBehaviour {

	public Transform LSpikes;
	public Transform RSpikes;
	public Transform SSpikes;
	public Transform Background;
	public Transform GOtext;

	public Sprite HOHOL_Back;
	public Sprite Vatnik_spike;
	public Sprite Hohol_Player;


	public AudioClip HimnUkr;



	void Sprite(){
		int ss = PlayerPrefs.GetInt ("Skin");


		if (ss == 1) {
			audio.clip = HimnUkr;
			audio.Play();
			GOtext.GetComponent<TextMesh>().text = "ЗРАДА!";
			Background.GetComponent<SpriteRenderer>().sprite = HOHOL_Back;
			GetComponent<SpriteRenderer>().sprite = Hohol_Player;
			foreach (Transform child in LSpikes)
				child.GetComponent<SpriteRenderer>().sprite = Vatnik_spike;
			foreach (Transform child in RSpikes)
				child.GetComponent<SpriteRenderer>().sprite = Vatnik_spike;
			foreach (Transform child in SSpikes)
				child.GetComponent<SpriteRenderer>().sprite = Vatnik_spike;
		}
		
	}

	
	void Start () {
		Sprite ();
	}





}
