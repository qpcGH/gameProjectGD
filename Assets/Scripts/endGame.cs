using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    // Start is called before the first frame update


    public void goBack()
    {
        SceneManager.LoadScene(0);
    }
    public void level_1()
    {
        SceneManager.LoadScene(1);
    }

    public void level_2()
    {
        SceneManager.LoadScene(2);
    }
    public void level_3()
    {
        SceneManager.LoadScene(3);
    }
    public void level_4()
    {
        SceneManager.LoadScene(4);
    }
    public void level_5()
    {
        SceneManager.LoadScene(5);
    }
}
