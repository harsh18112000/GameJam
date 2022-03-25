using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] panel;
    [SerializeField]
    private Text Score;
    [SerializeField]
    private Text HighScore;

    // Start is called before the first frame update
    void Start()
    {
       // panel[0].SetActive(true);
        //panel[1].SetActive(false);
    }
   public void startgame()
    {
        //Time.timeScale = 1;
        //SceneManager.LoadScene("GameScreen");
        //panel[1].SetActive(true);
        //panel[0].SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "score :" + EnemyDestroyer.scrore.ToString();
        HighScore.text = "score :" + EnemyDestroyer.scrore.ToString();
    }
}
