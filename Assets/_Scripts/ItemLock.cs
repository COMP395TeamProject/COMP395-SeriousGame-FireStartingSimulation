using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLock : MonoBehaviour {
    public float xRotate1;
    public float yRotate1;
    public float zRotate1;

    public float xPos1;
    public float yPos1;
    public float zPos1;

    public float xRotate2;
    public float yRotate2;
    public float zRotate2;

    public float xPos2;
    public float yPos2;
    public float zPos2;

    public float xRotate3;
    public float yRotate3;
    public float zRotate3;

    public float xPos3;
    public float yPos3;
    public float zPos3;
    // Use this for initialization
    void Start () {
        xRotate1 = 50;
        yRotate1 = -88;
        zRotate1 = -700;

        xPos1 = -2.182f;
        yPos1 = .432f;
        zPos1 = 2.363f;

        xRotate2 = 50;
        yRotate2 = -88;
        zRotate2 = -700;

        xPos2 = -2.182f;
        yPos2 = .432f;
        zPos2 = 2.363f;

        xRotate3 = 50;
        yRotate3 = -88;
        zRotate3 = -700;

        xPos3 = -2.182f;
        yPos3 = .432f;
        zPos3 = 2.363f;
    }
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("Log(Clone)").GetComponent<dropInPlace>().xRotate = xRotate1;
        GameObject.Find("Log(Clone)").GetComponent<dropInPlace>().yRotate = yRotate1;
        GameObject.Find("Log(Clone)").GetComponent<dropInPlace>().zRotate = zRotate1;

        GameObject.Find("Log(Clone)").GetComponent<dropInPlace>().xPos = xPos1;
        GameObject.Find("Log(Clone)").GetComponent<dropInPlace>().yPos = yPos1;
        GameObject.Find("Log(Clone)").GetComponent<dropInPlace>().zPos = zPos1;

    }
}
