using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Sar;
    public void Click_Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Click_Exit()
    {
        Application.Quit();
    }

    public void Click_Next_Level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void Click_Fire()
    {
        Instantiate(Bullet,Sar.transform.position,Quaternion.identity);
    }
}
