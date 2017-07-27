using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Apple")
        {
            Debug.Log("死");
        }
        else
        {
            Debug.Log("生きる");
        }
    }
}
