using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score;
    public TextMeshProUGUI Score_text;
    public GameObject gameStartUI;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Score_text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStart()
    {
        gameStartUI.SetActive(false);
        Score_text.gameObject.SetActive(true);
    }

   /* public void GameContinue()
    {
        Score_text.gameObject.SetActive(true);
    }*/
    public void Restart()
    {
        SceneManager.LoadScene("Ball Game");
    }

    public void Scoreup()
    {
        score++;
        Score_text.text = score.ToString();
    }
}
