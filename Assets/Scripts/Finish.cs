using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] Text Level;
    [SerializeField] Text winPrompt;
    int level = 1;
    float delayBeforeNextScene = 2f; // Adjust the delay as needed

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        level = SceneManager.GetActiveScene().buildIndex + 1;
        Level.text = "Level: " + level;

        if (level == 6)
        {
            winPrompt.text = "GAME WON FOR NOW";
        }
        }
    }

    
}


/*GAME WON
FOR 
NOW*/