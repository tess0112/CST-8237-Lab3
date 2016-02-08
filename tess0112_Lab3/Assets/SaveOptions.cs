using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SaveOptions : MonoBehaviour
{
    public Slider valueSlider;
    public Text buttonText;
    public Toggle toggleState;
    string sliderKey = "VALUE_SLIDER_INITIAL_VALUE";
    string toggleKey = "VALUE_TOGGLE_INITIAL_VALUE";
    string buttonKey = "VALUE_BUTTON_INITIAL_VALUE";

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey(sliderKey))
        {
            valueSlider.value = PlayerPrefs.GetFloat(sliderKey);
        }
        if (PlayerPrefs.HasKey(buttonKey))
        {
            buttonText.text = PlayerPrefs.GetString(buttonKey);
        }
        if (PlayerPrefs.HasKey(toggleKey))
        {
            if (PlayerPrefs.GetInt(toggleKey) == 1)
            {
                toggleState.isOn = true;
            }
            else
            {
                toggleState.isOn = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SaveOptionsValues()
    {
        PlayerPrefs.SetFloat(sliderKey, valueSlider.value);
        PlayerPrefs.SetString(buttonKey, buttonText.text);
        if (toggleState.isOn == true)
        {
            PlayerPrefs.SetInt(toggleKey, 1);
        }
        else
        {
            PlayerPrefs.SetInt(toggleKey, 0);
        }
        PlayerPrefs.Save();
    }
}
