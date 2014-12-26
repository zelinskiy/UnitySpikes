using UnityEngine;
using System.Collections;


//Must think about Spikes/Left Spikes scripts (DRY)

public class PlayerController : MonoBehaviour {

	public static float side = -1.0f;
	public float jumpForce = 500.0f;

	public static int NumOfSpikes = 0;
	private int NumOfTouches = 0;
	public static float rSpeed = 3f;	//Horisontal speed is constant
	private int ClipNum;				//number of music file, used in randomClip
	private bool IsDying = false;		//We must not be able to control our player when we failed

	//Various music
	public AudioClip First;
	public AudioClip Second;
	public AudioClip Third;
	public AudioClip Fourth;
	public AudioClip Fifth;

	public GameObject Spikes;
	public GameObject LeftSpikes;				
	public GameObject GUIObject;				//All GUI Parent
	public GameObject LvLText;					//N of touches
	public GameObject BestScore;

	void Update () {					

		//How much times we collided walls? Lets see:
		LvLText.GetComponent<TextMesh>().text = NumOfTouches.ToString();
		NumOfSpikes = NumOfTouches / 2;

		//Our velocity & controller
		rigidbody2D.velocity = new Vector2 (rSpeed * side, rigidbody2D.velocity.y);
		if (Input.GetButtonDown ("Jump") && !IsDying)
		{

			rigidbody2D.velocity = new Vector2 (rSpeed * side, 0);
			rigidbody2D.AddForce (new Vector2(20*side, jumpForce));	

		}




	}
	
	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "RightSide")
		{
			side = -1.0f;
			NumOfTouches += 1;
			Invoke("LSpikesDestroyerCaller", 2f);


		}
		if (c.gameObject.tag == "LeftSide")
		{
			Invoke("RSpikesDestroyerCaller", 2f);
			side = 1.0f;
			NumOfTouches += 1;

		}
		if (c.gameObject.tag == "Spike")

			GameOver ();

	
	}


	//We cant just Invoke these large things
	void LSpikesDestroyerCaller(){
			LeftSpikes.GetComponent<LeftSpikes>().Destroyer();
		}
	void RSpikesDestroyerCaller(){
			Spikes.GetComponent<Spikes>().Destroyer();
		}



	void GameOver(){
		//Printing your BestScore, Showing gui, hiding that big number, etc
		BestScore.GetComponent<TextMesh> ().text = "Best Score: " + PlayerPrefs.GetInt ("Best score").ToString ();
		GUIObject.SetActive (true);
		LvLText.SetActive (false);
		side *= -1;
		rigidbody2D.velocity = new Vector2 (side * -100, -2);
		collider2D.enabled = false;
		IsDying = true;

		if (PlayerPrefs.GetInt("Best score") < NumOfTouches)
			PlayerPrefs.SetInt("Best score", NumOfTouches);
	}
	public void Respawn(){

		GUIObject.SetActive (false);
		LvLText.SetActive (true);
		NumOfTouches = 0;
		collider2D.enabled = true;
		transform.position = new Vector2 (0, 0);
		rigidbody2D.velocity = new Vector2 (0, 0);
		side *= -1;
		IsDying = false;

	}

	public void RandomClip(){
		ClipNum = (int)Random.Range (1.0f, 5.0f);
		
		if (ClipNum == 1)
			audio.clip = First;
		else if (ClipNum == 2)
			audio.clip = Second;
		else if (ClipNum == 3)
			audio.clip = Third;
		else if (ClipNum == 4)
			audio.clip = Fourth;
		else if (ClipNum == 5)
			audio.clip = Fifth;
		audio.Play();
	}



			
		



	public static float Move
	{ 
		get { return side; }
	}
	public static int GetNumOfSpikes
	{
		get { return NumOfSpikes; }
	}






}
