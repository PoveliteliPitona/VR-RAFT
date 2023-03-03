using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject raft3;
    public GameObject raft2;
    public GameObject raft1;
    public int health = 3;
    public int scene;
    void Start()
    {
        raft3.SetActive(true);
        raft2.SetActive(false);
        raft1.SetActive(false);
    }

    void Update()
    {
        if (health<=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if (health == 2)
        {
            raft3.SetActive(false);
            raft2.SetActive(true);
            raft1.SetActive(false);
        }
        if (health == 1)
        {
            raft3.SetActive(false);
            raft2.SetActive(false);
            raft1.SetActive(true);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if  (other.gameObject.tag == "skala")
        {
            Destroy(other.gameObject);
            health--;
        }
        if (other.gameObject.tag == "win")
        {
            SceneManager.LoadScene(scene);
        }
    }
}
