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


	public Sprite SOVOK_back;
	public Sprite NaziSpike;
	public Sprite USSR_player;
	public AudioClip HimnSov;


	public Sprite Imp_Back;
	public Sprite Chlenin;
	public Sprite Stulin;
	public Sprite Imp_Player;
	public AudioClip Imp_March;



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
		else if (ss == 2) {
			audio.clip = HimnSov;
			audio.Play();
			GOtext.GetComponent<TextMesh>().text = "Расстрелять!";
			Background.GetComponent<SpriteRenderer>().sprite = SOVOK_back;
			GetComponent<SpriteRenderer>().sprite = USSR_player;
			foreach (Transform child in LSpikes)
				child.GetComponent<SpriteRenderer>().sprite = NaziSpike;
			foreach (Transform child in RSpikes)
				child.GetComponent<SpriteRenderer>().sprite = NaziSpike;
			foreach (Transform child in SSpikes)
				child.GetComponent<SpriteRenderer>().sprite = NaziSpike;
		}
		else if (ss == 3) {
			audio.clip = Imp_March;
			audio.Play();
			GOtext.GetComponent<TextMesh>().text = "У тебя 1917!";
			Background.GetComponent<SpriteRenderer>().sprite = Imp_Back;
			GetComponent<SpriteRenderer>().sprite = Imp_Player;
			foreach (Transform child in LSpikes)
				child.GetComponent<SpriteRenderer>().sprite = Chlenin;
			foreach (Transform child in RSpikes)
				child.GetComponent<SpriteRenderer>().sprite = Stulin;
			foreach (Transform child in SSpikes)
				child.GetComponent<SpriteRenderer>().sprite = Stulin;
		}

	}

	
	void Start () {
		Sprite ();
	}





}
