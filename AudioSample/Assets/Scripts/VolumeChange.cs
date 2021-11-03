using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VolumeChange : MonoBehaviour
{
    [SerializeField]
    AudioSource _audioSource;
    private Slider _slider;
    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();

    }

    // Update is called once per frame
    public void VolManager()
    {
        _audioSource.volume = _slider.value;
    }
}
