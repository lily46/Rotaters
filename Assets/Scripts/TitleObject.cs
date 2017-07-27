using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleObject : MonoBehaviour {

    float t = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        transform.eulerAngles = new Vector3(0, 0, 120 * Mathf.Sin(Mathf.PI * t * 7f / 180));
	}
}
