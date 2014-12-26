using UnityEngine;
using System.Collections;

public class MusicRandomButton : MonoBehaviour {
	public GameObject Player;
	void OnMouseDown(){
		Player.GetComponent<PlayerController>().RandomClip();

	}
}
