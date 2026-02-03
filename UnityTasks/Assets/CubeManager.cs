using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class CubeManager : MonoBehaviour
{
    public Transform cube;   
    public Slider slider;    
    public TMP_Text displayText;
    public TMP_InputField inputField;

    
    public void ChangeText()
    {
        displayText.text = inputField.text;
    }
    void Start()
    {
        SetCubeScale(slider.value=0.2f);
        slider.onValueChanged.AddListener(SetCubeScale);
    }

    void SetCubeScale(float value)
    {
        cube.localScale = new Vector3(value, value, value);
        Debug.Log(value);
    }
}
