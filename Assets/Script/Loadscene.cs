using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadscene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScreen");
        
    }
    public void exit()
    {
        Application.Quit();
    }
}

