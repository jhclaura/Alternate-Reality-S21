using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCube : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public Color hoverColor;

    private Material material;
    private Color originalColor;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        originalColor = material.color;
    }

    public void OnPointerEnter()
    {
        audioSource.transform.position = transform.position;
        audioSource.PlayOneShot(audioClip);
        material.color = hoverColor;
    }

    public void OnPointerExit()
    {
        material.color = originalColor;
    }
}
