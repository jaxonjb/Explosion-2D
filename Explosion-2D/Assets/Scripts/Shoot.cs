using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(Resources.Load("Prefabs/Bullet") as GameObject);
            Vector3 pos = transform.position;
            pos.x += 2f;
            pos.y += .75f;
            bullet.transform.position = pos;
        }
    }
}
