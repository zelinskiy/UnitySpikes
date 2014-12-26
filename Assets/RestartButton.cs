using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {


	public GameObject Spikes;
	public GameObject LeftSpikes;



	public GameObject Player;
	void OnMouseDown(){
		Player.GetComponent<PlayerController>().Respawn();
		LeftSpikes.GetComponent<LeftSpikes>().AbsDestroyer();
		Spikes.GetComponent<Spikes>().AbsDestroyer();
		
	}
}
