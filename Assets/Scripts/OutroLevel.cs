using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutroLevel : MonoBehaviour
{
    public void loadNextLevel()
    {
	SceneManager.LoadScene("Outro");
    }
}
