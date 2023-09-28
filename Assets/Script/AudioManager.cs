using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] float _waitTime = 1.0f;

    AudioSource _audio;

    void Start()
    {
        _audio = GetComponent<AudioSource>();
        StartCoroutine(PlayBGM());
    }

    IEnumerator PlayBGM()
    {
        yield return new WaitForSeconds(_waitTime);
        _audio.Play();
    }
}
