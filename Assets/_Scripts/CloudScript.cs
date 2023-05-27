using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float cloudSpeed = 2;
    public float cloudDeathZone = -60;
    void Update()
    {
        transform.position = transform.position + (Vector3.left * cloudSpeed) * Time.deltaTime;
        if (transform.position.x < cloudDeathZone)
        {
            Destroy(gameObject);
        }

    }
}
