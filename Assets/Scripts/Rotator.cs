﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {



	void Update () {
		transform.Rotate(new Vector3(0,0,Time.deltaTime * 50));
	}
}
