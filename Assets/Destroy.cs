using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    private GameObject maincamera;

    private float difference;

    // Use this for initialization
    void Start () {

        this.maincamera = GameObject.Find("Main Camera");

        
	}
	
	// Update is called once per frame
	void Update () {

        if(this.transform.position.z < maincamera.transform.position.z)
        {
            Destroy(this.gameObject);

            Debug.Log("削除されました。" + gameObject.name);
   
        }
		
	}
}
