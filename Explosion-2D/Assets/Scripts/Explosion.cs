using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public new AudioSource audio;
    // Start is called before the first frame update
    
    void Start()
    {
        audio = GetComponent<AudioSource>();
        if (audio != null) {
            audio.Play();
        }
    }

    // FOR USE INDEPENDENT OF OTHER GAME OBJECTS
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     Destroy(transform.gameObject, 1.1f);
    //     Destroy(collision.gameObject, 0.5f);
    // }
}
