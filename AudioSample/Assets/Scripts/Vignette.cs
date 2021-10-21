using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.InputSystem;
using System;

public class Vignette : MonoBehaviour
{//intesity of the fade adn how long it lasts
    [SerializeField]
    float intensity = 0.75f;
    [SerializeField]
    float duration = 0.5f;

    [SerializeField]
    private Volume volume;
    Vignette vignette;
    //can determine if the joystick is pressed and where that position is in game
    [SerializeField]
    InputActionReference continuousMove;

    //when joystick is pressed,fade in; when released, fade out.
    private void Awake()
    {
        continuousMove.action.performed += FadeIn;
        continuousMove.action.canceled += FadeOut;

        if (volume.profile.TryGet(out Vignette vignette))
            this.vignette = vignette;
    }
     //when released fade out
    private void FadeOut(InputAction.CallbackContext obj)
    {
        StartCoroutine(Fade(0, intensity));
    }
    
    //when pressed, if value is not zero, fades in
    private void FadeIn(InputAction.CallbackContext obj)
    {
        if (obj.ReadValue<Vector2>() != Vector2.zero)
        {
            StartCoroutine(Fade(intensity, 0));
        }
    }
    IEnumerator Fade(float startValue, float endValue)
    {
        float elapsedTime = 0.0f;
        float blend = elapsedTime / duration;
        //calculating the intesisty of the vignette by / values
        float intensity = Mathf.Lerp(startValue, endValue, blend);
        ApplyValue(intensity);
        yield return null;
    }
    //applying the inestity to the vignette
    void ApplyValue(float value)
    {
        vignette.intensity.Override(value);
    }
}