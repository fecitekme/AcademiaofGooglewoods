using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBack : MonoBehaviour
{
    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}