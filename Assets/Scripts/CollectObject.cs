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
        if (collider.CompareTag("objectTree") && currentInterObject == null)
        {
            currentInterObject = collider.gameObject;
        }

        if (collider.CompareTag("objectStone") && currentInterObject == null)
        {
            currentInterObject = collider.gameObject;
        }

        if (collider.CompareTag("objectFridge") && currentInterObject == null)
        {
            currentInterObject = collider.gameObject;
        }


        if (collider.CompareTag("objectBarrage") &&
            currentInterObject.name == "ObjectFridge" &&
            currentInterObject != null)
        {
            currentInterObject = null;

            highscoreInt += 2;

            highscore.text = highscoreInt.ToString();
        }

        if (collider.CompareTag("objectBarrage") && 
            currentInterObject.name != "ObjectFridge" &&
            currentInterObject != null)
        {       
            currentInterObject = null;

            highscoreInt++;
            
            highscore.text = highscoreInt.ToString();
        }
        
    }
}
