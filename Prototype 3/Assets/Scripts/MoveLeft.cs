using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    private float speed = 30f;
    private float leftBound = -15f;

    private PlayerController _playerController;
    // Start is called before the first frame update
    void Start() {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update() {
        if (_playerController.gameOver) return;
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) {
            Destroy(gameObject);
        }
    }
}
