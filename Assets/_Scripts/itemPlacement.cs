using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPlacement : MonoBehaviour {

    public int logsPlaced;
    public int rocksPlaced;

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
        logsPlaced = 0;
        rocksPlaced = 0;

    }
	
	// Update is called once per frame
	void Update () {
        

        xRotate3 = 50;
        yRotate3 = -88;
        zRotate3 = -700;

        xPos3 = -2.182f;
        yPos3 = .432f;
        zPos3 = 2.363f;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "log")
        {
            if (logsPlaced == 0)
            {
                xRotate1 = 50;
                yRotate1 = -88;
                zRotate1 = -700;

                xPos1 = -2.182f;
                yPos1 = .432f;
                zPos1 = 2.363f;

                other.GetComponent<dropInPlace>().xRotate = xRotate1;
                other.GetComponent<dropInPlace>().yRotate = yRotate1;
                other.GetComponent<dropInPlace>().zRotate = zRotate1;

                other.GetComponent<dropInPlace>().xPos = xPos1;
                other.GetComponent<dropInPlace>().yPos = yPos1;
                other.GetComponent<dropInPlace>().zPos = zPos1;

                other.GetComponent<dropInPlace>().locked = true;
                logsPlaced+=1;
            }

            else if (logsPlaced == 1)
            {
                xRotate1 = 50;
                yRotate1 = -88;
                zRotate1 = -700;

                xPos1 = -2.182f;
                yPos1 = .432f;
                zPos1 = 2.363f;

                other.GetComponent<dropInPlace>().xRotate = xRotate1;
                other.GetComponent<dropInPlace>().yRotate = yRotate1;
                other.GetComponent<dropInPlace>().zRotate = zRotate1;

                other.GetComponent<dropInPlace>().xPos = xPos1;
                other.GetComponent<dropInPlace>().yPos = yPos1;
                other.GetComponent<dropInPlace>().zPos = zPos1;

                other.GetComponent<dropInPlace>().locked = true;
                logsPlaced+=1;
            }

            else if (logsPlaced == 2)
            {
                xRotate1 = 50;
                yRotate1 = -88;
                zRotate1 = -700;

                xPos1 = -2.182f;
                yPos1 = .432f;
                zPos1 = 2.363f;

                other.GetComponent<dropInPlace>().xRotate = xRotate1;
                other.GetComponent<dropInPlace>().yRotate = yRotate1;
                other.GetComponent<dropInPlace>().zRotate = zRotate1;

                other.GetComponent<dropInPlace>().xPos = xPos1;
                other.GetComponent<dropInPlace>().yPos = yPos1;
                other.GetComponent<dropInPlace>().zPos = zPos1;

                other.GetComponent<dropInPlace>().locked = true;
                logsPlaced += 1;
            }

        }

        else if (other.gameObject.name == "rock")
        {
            if (rocksPlaced == 0)
            {
                xRotate1 = 50;
                yRotate1 = -88;
                zRotate1 = -700;

                xPos1 = -2.182f;
                yPos1 = .432f;
                zPos1 = 2.363f;

                other.GetComponent<dropInPlace>().xRotate = xRotate1;
                other.GetComponent<dropInPlace>().yRotate = yRotate1;
                other.GetComponent<dropInPlace>().zRotate = zRotate1;

                other.GetComponent<dropInPlace>().xPos = xPos1;
                other.GetComponent<dropInPlace>().yPos = yPos1;
                other.GetComponent<dropInPlace>().zPos = zPos1;

                other.GetComponent<dropInPlace>().locked = true;
                rocksPlaced += 1;
            }

            else if (rocksPlaced == 1)
            {
                xRotate1 = 50;
                yRotate1 = -88;
                zRotate1 = -700;

                xPos1 = -2.182f;
                yPos1 = .432f;
                zPos1 = 2.363f;

                other.GetComponent<dropInPlace>().xRotate = xRotate1;
                other.GetComponent<dropInPlace>().yRotate = yRotate1;
                other.GetComponent<dropInPlace>().zRotate = zRotate1;

                other.GetComponent<dropInPlace>().xPos = xPos1;
                other.GetComponent<dropInPlace>().yPos = yPos1;
                other.GetComponent<dropInPlace>().zPos = zPos1;

                other.GetComponent<dropInPlace>().locked = true;
                rocksPlaced += 1;
            }

            else if (rocksPlaced == 2)
            {
                xRotate1 = 50;
                yRotate1 = -88;
                zRotate1 = -700;

                xPos1 = -2.182f;
                yPos1 = .432f;
                zPos1 = 2.363f;

                other.GetComponent<dropInPlace>().xRotate = xRotate1;
                other.GetComponent<dropInPlace>().yRotate = yRotate1;
                other.GetComponent<dropInPlace>().zRotate = zRotate1;

                other.GetComponent<dropInPlace>().xPos = xPos1;
                other.GetComponent<dropInPlace>().yPos = yPos1;
                other.GetComponent<dropInPlace>().zPos = zPos1;

                other.GetComponent<dropInPlace>().locked = true;
                rocksPlaced += 1;
            }

        }
    }
}
