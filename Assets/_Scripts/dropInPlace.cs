using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropInPlace : MonoBehaviour {

    public GameObject log;
    public float xRotate, yRotate, zRotate;
    public float xPos, yPos, zPos;
    public bool locked = false;
    //Rigidbody rb = log.GetComponent<Rigidbody>();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (locked == true)
        {
            transform.eulerAngles = new Vector3(xRotate, yRotate, zRotate);
            transform.position = new Vector3(xPos, yPos, zPos);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        locked = true;
    }
}
