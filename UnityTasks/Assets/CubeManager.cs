using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour
{
    public Transform cube;   
    public Slider slider;    

    void Start()
    {
        SetCubeScale(slider.value);
        slider.onValueChanged.AddListener(SetCubeScale);
    }

    void SetCubeScale(float value)
    {
        cube.localScale = new Vector3(value, value, value);
    }
}
