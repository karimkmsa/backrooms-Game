using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public static int score;

    public TextMeshProUGUI   scoreText;

    void Start()
    {
        score = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}