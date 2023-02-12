using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static float PlayingSpeed = 15;
    public static float PlayingSize = 1;

    public Slider speedSlider;
    public Text speedSliderValue;

    public Slider sizeSlider;
    public Text sizeSliderValue;

    public GameObject Player;
    public TMP_Dropdown ColorDropdown;
    public TMP_Text ColorText;

    public static int colorValue = 0;


    public void SetSpeed() //method for the slider on intro screen
    {
        PlayingSpeed = speedSlider.value;
        speedSliderValue.text = PlayingSpeed.ToString();
    }
    public void SetSize() //method for the slider on intro screen
    {
        PlayingSize = sizeSlider.value;
        sizeSliderValue.text = PlayingSize.ToString();
    }
    public void ChooseColor()
    {
        switch (ColorDropdown.value)
        {
            case 1:
                ColorText.text = ColorDropdown.options[1].text;
                Player.GetComponent<Renderer>().material.color = Color.blue;
		colorValue = ColorDropdown.value;
                break;
            case 2:
                ColorText.text = ColorDropdown.options[2].text;
                Player.GetComponent<Renderer>().material.color = Color.yellow;
		colorValue = ColorDropdown.value;
                break;
            case 3:
                ColorText.text = ColorDropdown.options[3].text;
                Player.GetComponent<Renderer>().material.color = Color.red;
		colorValue = ColorDropdown.value;
                break;
            default:
                ColorText.text = ColorDropdown.options[0].text;
                Player.GetComponent<Renderer>().material.color = Color.blue;
		colorValue = ColorDropdown.value;
                break;
        }
    }

}
