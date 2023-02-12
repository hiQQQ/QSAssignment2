using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevel : MonoBehaviour
{
    public void loadNextLevel()
    {
	SceneManager.LoadScene("GameScene");
    }
}
