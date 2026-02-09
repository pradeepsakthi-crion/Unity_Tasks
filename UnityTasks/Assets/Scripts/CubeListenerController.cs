using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CubeListenerController : MonoBehaviour
{
    public Slider  slider;
    public TextMeshProUGUI text;
    public Transform cube;
    public TMP_InputField inputField;

    void Start()
    {
        slider.onValueChanged.AddListener(OnSizeChanged);
        inputField.onValueChanged.AddListener(OnNameChanged);
    }

    public void OnSizeChanged(float value)
    {
        cube.localScale = Vector3.one * value;
    }

    public void OnNameChanged(string newText)
    {
        cube.name = newText;
        text.text = newText;
        
    }

    
}
