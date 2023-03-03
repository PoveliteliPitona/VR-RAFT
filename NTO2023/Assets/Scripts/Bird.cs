using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Transform[] PathElements;
    public GameObject go;
    private int point;
    private int n;
    public float speed = .5f;
    private bool alive;
    void Start()
    {
        point = 0;
        alive = true;
    }
    void Update()
    {
        if (point == 0 && alive)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90f, 180f, 0f);
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, PathElements[1].transform.position, speed);
            if (gameObject.transform.position == PathElements[1].transform.position)
            {
                point = 1;
            }
        }
        if (point == 1 && alive)
        {
            gameObject.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, PathElements[0].transform.position, speed);
            if (gameObject.transform.position == PathElements[0].transform.position)
            {
                point = 0;
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "stone")
        {
            alive = false;
            gameObject.AddComponent<Rigidbody>();
        }
    }
}