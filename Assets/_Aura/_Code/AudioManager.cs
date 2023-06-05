using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource m_AudioSource;
    [SerializeField] AudioClip m_ButtonFx;
    [SerializeField] AudioClip m_MatButtonFx;

    public void PlayButtonFx()
    {
        m_AudioSource.PlayOneShot(m_ButtonFx);
    }
    public void PlayMatButtonFx()
    {
        m_AudioSource.PlayOneShot(m_MatButtonFx);
    }
}
