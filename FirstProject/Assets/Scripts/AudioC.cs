using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioC : MonoBehaviour
{
    private AudioSource adoSoc;

    public AudioClip adoClp;
    public Slider adoSlider;
    public Text adoVolumeTxt;
    public Toggle adoMuteTgl;

    private bool isOn = true;

    // Start is called before the first frame update
    void Start()
    {
        adoSoc = GetComponent<AudioSource>();

        adoSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        adoMuteTgl.onValueChanged.AddListener(SetMute);

        adoSlider.value = 0.6f;
        adoSoc.volume = 0.6f;
        adoVolumeTxt.text = "60.0 %";
        adoSoc.clip = adoClp;
        adoSoc.Play();

    }

    private void SetMute(bool arg0)
    {
        if (isOn)
        {
            isOn = false;
        }
        else
        {
            isOn = true;
        }

        adoSoc.mute = isOn;
    }

    private void ValueChangeCheck()
    {
        adoSoc.volume = adoSlider.value;
        adoVolumeTxt.text = string.Format("{0:F1} %", adoSlider.value * 100);
    }
    void Update()
    {
        ValueChangeCheck();
    }
}
