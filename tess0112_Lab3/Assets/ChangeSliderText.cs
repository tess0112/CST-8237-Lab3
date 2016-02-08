using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeSliderText : MonoBehaviour
{

    public Text textToChange;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeTextWithSliderBalue(Slider slider)
    {
        if (slider)// && textToChange)
        {
            // Gets the Text child object of the button and changes the text of the child.
            textToChange.text = "Metric Tons of Ice: " + slider.value;
            textToChange.transform.localScale = new Vector3(slider.value * 0.01f, slider.value * 0.01f, slider.value * 0.01f);
        }
    }
}