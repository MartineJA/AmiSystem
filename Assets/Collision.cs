using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public GameObject panel;
    public GameObject vCam;
    public GameObject fLCam;

    private void OnTriggerEnter(Collider other)
    {
        //panel.SetActive(true);
        vCam.SetActive(true);
        fLCam.SetActive(false);
        
        Debug.Log("collision");


    }


}
