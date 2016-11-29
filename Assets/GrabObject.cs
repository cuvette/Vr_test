using UnityEngine;
using System.Collections;

public class GrabObject : MonoBehaviour
{
    private GameObject movable;


    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One) && movable != null)
        {
            Debug.Log("Button A pushed");
            movable.GetComponent<Rigidbody>().useGravity = false;
            movable.gameObject.transform.position = this.transform.position;
            movable.gameObject.transform.rotation = this.transform.rotation;
        }

        else if (OVRInput.Get(OVRInput.Button.One) == false && movable != null)
        {
            movable.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered a trigger");
        movable = other.gameObject;

    }

    void OnTriggerExit(Collider other)
    {
        movable = null;
    }
}

