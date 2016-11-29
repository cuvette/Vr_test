using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

    public GameObject rightHand;
    public GameObject leftHand;


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        HandPos();
        HandRot();

    }

    void HandPos() // Place the hand at the controller position
    {
        rightHand.transform.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        leftHand.transform.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
    }

    void HandRot()
    {
        rightHand.transform.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
        leftHand.transform.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
    }

}
