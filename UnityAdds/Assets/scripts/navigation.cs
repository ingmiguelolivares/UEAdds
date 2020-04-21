using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class navigation : MonoBehaviour
{
    public Text MessageLabel, ScoreLabel;

   
    // Update is called once per frame
    void Update()
    {
        MessageLabel.text = scores.message;
        ScoreLabel.text = "Puntos: " + scores.score.ToString();
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

}