using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
#region Singleton

    public static GameManager Instance = null;
    private void Awake()
    {
        Instance = this;

    }
    #endregion

    public int score = 0; //Scorekeeping
    public void AddScore(int scoreToAdd)
    {
        //Increase Score Value by incoming score
        score += scoreToAdd;
        // Update UI Here
        UIManager.Instance.UpdateScore(score);
    }
    public void restart()
    {
        // Load the Active Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        //Loads the next level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Prevlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
    //DEBUGGING PUR
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}