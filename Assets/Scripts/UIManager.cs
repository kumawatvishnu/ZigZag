using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager instance;

    public GameObject zigzagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public Text score;
    public Text highScore1;
    public Text highScore2;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
        highScore1.text = "High Score: "+PlayerPrefs.GetInt("highScore").ToString();
    }

    public void GameStart()
    {
        tapText.GetComponent<Animator>().Play("textDown");
        zigzagPanel.GetComponent<Animator>().Play("panelUp");
        //tapText.SetActive(false);
    }
    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highScore2.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
    }
	public void Restart()
    {
        SceneManager.LoadScene(0);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
