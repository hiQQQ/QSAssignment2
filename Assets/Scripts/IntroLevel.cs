using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroLevel : MonoBehaviour
{
    public void loadIntroLevel()
    {
	SceneManager.LoadScene("Intro");
    }
    public void ExitGame()
    {
	UnityEditor.EditorApplication.isPlaying = false;
    }
}
