using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObject : MonoBehaviour
{
    public GameObject currentInterObject = null;
    public Collider2D collider;

    public Text highscore;
    public int highscoreInt;


    void Start()
    {
        highscoreInt = 0;        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("objectTree"))
        {
            currentInterObject = collider.gameObject;
        }


        if (collider.CompareTag("objectBarrage") && currentInterObject != null)
        {       
            currentInterObject = null;

            highscoreInt++;


            Debug.Log(highscoreInt.ToString());
            Debug.Log(currentInterObject);

            highscore.text = "TREFFER";

        }
    }
}
