using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{

    public float pipeSpeed = 5;
    public float pipeDeathZone = -60;
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;
        if (transform.position.x < pipeDeathZone)
        {
            Destroy(gameObject);
        }

    }
}
