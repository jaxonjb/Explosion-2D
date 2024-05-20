using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.smoothDeltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Example Instantiation of explosion
        GameObject explosion = Instantiate(Resources.Load("Prefabs/Explosion") as GameObject);
        explosion.transform.position = transform.position;
        //Scales Explosion size to the scale of the object exploding.
        explosion.transform.localScale = transform.localScale;
        //Animation takes ~ 1 second, so destroy after 1.1 seconds. Adjust this number is animation is changed
        Destroy(explosion, 1.1f);
        Destroy(transform.gameObject);
        Destroy(collision.gameObject);
    }
}
