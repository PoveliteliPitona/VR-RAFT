using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalvnikRotation : MonoBehaviour
{

    public Transform target;

    public float smoothTime = 0.1f;
    public float distance = 2f;


    // Update is called once per frame
    void Update()
    {


        transform.position = Vector3.Lerp(transform.position, target.position + target.forward * distance, smoothTime);
        transform.LookAt(target);
    }
}
