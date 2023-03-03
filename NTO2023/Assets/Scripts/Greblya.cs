using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Greblya : MonoBehaviour
{
    private GameObject player;
    public float speed;
    public Rigidbody rb;
    public float force = 5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "ocean")
        {
            if (hit.controller.tag == "veslo")
            {
                rb.AddForce(hit.moveDirection.x * force, 0, hit.moveDirection.z * force, ForceMode.Impulse);
            }
        }
        
    }
    
}
