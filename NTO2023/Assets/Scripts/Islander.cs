using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Islander : MonoBehaviour
{
    public GameObject is1;
    public GameObject is2;
    public GameObject is3;
    public GameObject main;
    public int dictx2 = 100;
    public int dictx3 = 200;

    private void Start()
    {
        is2.SetActive(false); 
        is3.SetActive(false);
    }
    void Update()
    {
        if (main.transform.position.x < dictx2)
        {
            is1.SetActive(true);
            is2.SetActive(false);
            is3.SetActive(false);
        }
        if (main.transform.position.x > dictx2 && main.transform.position.x < dictx3)
        {
            is1.SetActive(false);
            is2.SetActive(true);
        }
        if (main.transform.position.x > dictx3)
        {
            is2.SetActive(false);
            is3.SetActive(true);
        }
    }
}
