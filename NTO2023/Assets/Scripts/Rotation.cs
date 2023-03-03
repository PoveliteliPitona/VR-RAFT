using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotation : MonoBehaviour
{
    public GameObject pl;
    public float smooth=0.005f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Traker")
        {
            pl.transform.rotation = Quaternion.Lerp(pl.transform.rotation, Quaternion.Euler(0f, pl.transform.rotation.y -30f, 0f), smooth);
            Debug.Log("4");
        }
    }

}

    
