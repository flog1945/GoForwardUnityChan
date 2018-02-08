using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSE : MonoBehaviour {

    //効果音
    private AudioClip block;
    private AudioSource audioSource;

    // Use this for initialization
    void Start ()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
            audioSource.Play();
    }
}
