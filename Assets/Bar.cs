using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {

    Vector3 startPos;
    Vector3 startVector;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TouchInfo info = AppUtil.GetTouch();
        if (info == TouchInfo.Began){
            startPos = AppUtil.GetTouchPosition();
            startVector = transform.eulerAngles;
        }else if(info == TouchInfo.Moved || info == TouchInfo.Stationary){
            float atan = Mathf.Atan2(AppUtil.GetTouchPosition().y - startPos.y, AppUtil.GetTouchPosition().x - startPos.x);
            float z = (startVector.z + atan) * 180f / Mathf.PI;
            transform.eulerAngles = new Vector3(0, 0, z);
            //Debug.Log(z + " " + startVector.z + " " + atan);
        }
    }

    
}
