 using UnityEngine;
 using System.Collections;

[RequireComponent(typeof(MeshCollider))]

public class mouseMoveScript : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;
    private bool enabled = true;

    void OnMouseDown()
    {
        if (enabled==true)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        }

    }

    void OnMouseDrag()
    {
        if (enabled == true)
        {
            float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        enabled = false;
    }
}