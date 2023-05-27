using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{

    public float flapStrength;
    public Rigidbody2D myRigidBody2D;
    private bool fishIsAlive = true;
    public GameManagerScript gameManagerScript;
    public float fallMultiplier;
    private AudioSource audioSource;

    [SerializeField] private AudioClip jump;
    [SerializeField] private AudioClip hit;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && fishIsAlive)
        {
            myRigidBody2D.velocity = Vector2.up * flapStrength;
        }

        if(myRigidBody2D.velocity.y < 0)
        {
            myRigidBody2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
            fishIsAlive = false;
            audioSource.PlayOneShot(hit);
            gameManagerScript.GameOver();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "PipeTrigger")
        {
            gameManagerScript.IncreaseScore();
        }
    }

}
