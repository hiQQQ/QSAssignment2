using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsLevel : MonoBehaviour
{
    public void loadSettingsLevel()
    {
	SceneManager.LoadScene("Settings");
    }
}
