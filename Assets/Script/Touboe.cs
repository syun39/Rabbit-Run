using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touboe : MonoBehaviour
{
    public AudioClip _se;
    private void OnTriggerEnter2D(Collider2D collision) => GetComponent<AudioSource>().PlayOneShot(_se);
}
