using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewDetector : MonoBehaviour {

    public Material lookingMat;
    public Material notLookingMat;
    public bool isViewed;

    GameObject Well_Done_Var;
    GameObject GvrReticlePointer_Var;
    GameObject Goal_Var;

    // Use this for initialization
    void Start () {
        isViewed = false;
        Well_Done_Var = GameObject.Find("Well_Done");
        Well_Done_Var.SetActive(false);
        GvrReticlePointer_Var = GameObject.Find("GvrReticlePointer");
        Goal_Var = GameObject.Find("Goal");
    }

    public void isSeen()
    {
        if (!isViewed)
        {
            GetComponent<Renderer>().material = lookingMat;
            isViewed = true;
            Well_Done_Var.SetActive(true);
            GvrReticlePointer_Var.SetActive(false);

            Goal_Var.SetActive(false);
        }
    }

    public void isNotSeen()
    {
        if (isViewed)
        {
            GetComponent<Renderer>().material = notLookingMat;
            isViewed = false;
        }
    }
}