using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSound : MonoBehaviour
{
    [SerializeField] AudioSource sound;
    public void PlaySound()
    {
        sound.Play();
    }
}
