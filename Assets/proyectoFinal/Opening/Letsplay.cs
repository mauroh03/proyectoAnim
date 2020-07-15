using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Letsplay : MonoBehaviour
{
    
    public void PlayGame()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            //restart
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            print("Saliendo");
            Application.Quit();
        }
    }
}
