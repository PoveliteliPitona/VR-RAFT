using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Zdorovie : MonoBehaviour
{
    public int scene;
    public static int health;
    public static bool gameOver;
    public GameObject Overlay;
    public float timeRemaining;



    void Start()
    {
        health = 100;
        gameOver = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            SceneManager.LoadScene(scene);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            timeRemaining = 10;
            if (timeRemaining > 0)

            {

                timeRemaining -= Time.deltaTime;

            }
            if (timeRemaining <= 0)
            {
                health--;
            }
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (health <= 100){
            health++;
        }
    }
    
}
