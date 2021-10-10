using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void ToScene2()
    {
        SceneManager.LoadScene(2);
    }

    public void ToScene3()
    {
        SceneManager.LoadScene(3);
    }

    public void ToScene4()
    {
        SceneManager.LoadScene(4);
    }

    public void ToScene5()
    {
        SceneManager.LoadScene(5);
    }

    public void ToScene6()
    {
        SceneManager.LoadScene(6);
    }

    public void ToScene7()
    {
        SceneManager.LoadScene(7);
    }

    public void ToScene8()
    {
        SceneManager.LoadScene(8);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
