using TMPro;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void ChangeSize(float value)
    {
        transform.localScale =  Vector3.one*value;
    }

    public void ChangeText(string newText)
    {
        gameObject.name = newText;
        text.text = newText;
        
    }
}
