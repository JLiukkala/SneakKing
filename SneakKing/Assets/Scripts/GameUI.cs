using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject gameLoseUI;
    bool gameIsOver;

    void Start()
    {
        Enemy.OnEnemyHasSpottedPlayer += ShowGameLoseUI;
    }

    void Update()
    {
        if (gameIsOver)
        {
            if (Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene(0);
            }
        }
    }

    void ShowGameLoseUI()
    {
        gameLoseUI.SetActive(true);
        gameIsOver = true;
        Enemy.OnEnemyHasSpottedPlayer -= ShowGameLoseUI;
    }
}
