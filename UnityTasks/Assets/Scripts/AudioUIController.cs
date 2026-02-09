using UnityEngine;
using UnityEngine.UI;

public class AudioUIController : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // Sync slider with current volume
        volumeSlider.value = AudioManager.Instance.GetVolume();

        volumeSlider.onValueChanged.AddListener(OnSliderChanged);
    }

    public void OnSliderChanged(float value)
    {
        AudioManager.Instance.SetVolume(value);
    }

    public void OnMuteButtonClick()
    {
        AudioManager.Instance.ToggleMute();

        // Update slider visually
        if (AudioManager.Instance.isMuted)
            volumeSlider.value = 0f;
        else
            volumeSlider.value = AudioManager.Instance.GetVolume();
    }
}
