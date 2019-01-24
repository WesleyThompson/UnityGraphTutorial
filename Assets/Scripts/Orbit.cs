using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

    public float orbitSpeed;
	
	void Update () {
        transform.Rotate(0f, orbitSpeed * Time.deltaTime, 0f);
	}
}
