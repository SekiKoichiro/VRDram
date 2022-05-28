using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;

public class Crash_Cymbal : UdonSharpBehaviour
{
    public AudioClip sound1; //音声読み込む
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(sound1);//音声を流す（.aif wav mp3 ogg）
        //Destroy(this.gameObject);
    }
}
