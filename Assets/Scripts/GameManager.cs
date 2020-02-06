using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public bool gameOver;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
        gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GameStart()
    {
        UIManager.instance.GameStart();
        ScoreManager.instance.StartScore();
        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().StartPfSpawning();
    }
    public void GameOver()
    {
        gameOver = true;
        UIManager.instance.GameOver();
        ScoreManager.instance.StopScore();
    }
}
