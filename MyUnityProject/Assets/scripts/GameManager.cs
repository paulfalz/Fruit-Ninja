using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region properties
    //static properties are available across the entire game
    //without having a reference to a game object
    public static bool IsPlaying { get; private set; }

    //used to determine wheter or not game has started
    public static bool GameHasStarted { get; private set; }
    #endregion

    #region methods
    //meth to start the game 
    void Start()
    {
        //give play control over actions
        IsPlaying = true;
        //game has started 
        GameHasStarted = true;
        FindObjectOfType<blade>().StartCutting();
        FindObjectOfType<fruitspawn>().Spawn();
    }

    public static void StopGame()
    {

        // show the Game Over UI
        //Transform gameOverUI = FindObjectOfType<Canvas>().Get("GameOver");
        //gameOverUI.gameObject.SetActive(true);

        // stop the play mode
        IsPlaying = false;

    }



    // static variables do not reset when the scene reloads,
    // therefore, we need to reset them manually
    public static void Reset()
    {
        IsPlaying = false;
        GameHasStarted = false;
    }
    #endregion
}
