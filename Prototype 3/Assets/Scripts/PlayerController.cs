using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float jumpForce = 10;
    public float gravityMultiplier = 3;
    public bool isOnGround = true;
    public bool gameOver = false;
    public ParticleSystem explosionParticleSystem;
    public ParticleSystem dirtParticleSystem;
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudioSource;

    public AudioClip jumpSound;
    public AudioClip crashSound;

    // Start is called before the first frame update
    void Start() {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudioSource = GetComponent<AudioSource>();
        Physics.gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticleSystem.Stop();
            playerAudioSource.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = true;
            dirtParticleSystem.Play();
        } else if (collision.gameObject.CompareTag("Obstacle")) {
            gameOver = true;
            Debug.Log("Game over!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticleSystem.Play();
            dirtParticleSystem.Stop();
            playerAudioSource.PlayOneShot(crashSound, 1.0f);
        }
    }
}
