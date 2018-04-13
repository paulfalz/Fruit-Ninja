using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public int score { get; private set; }     // The player's score.


    Text Score;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        Score = GetComponent<Text>();

        // Reset the score.
        score = 0;
    }

    public void AddScore()
    {
        // increment the score
        score++;
    }

    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        Score.text = "Score: " + score;
    }
}