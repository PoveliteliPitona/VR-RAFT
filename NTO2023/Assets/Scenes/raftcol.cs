using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raftcol : MonoBehaviour
{
    public float speed;
    public GameObject raft;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(raft.transform.position.x, raft.transform.position.y , raft.transform.position.z);
    }
}