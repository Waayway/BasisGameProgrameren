using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {
    private float _topBound = 30;

    private float _bottomBound = -10;

    // Update is called once per frame
    void Update() {
        if (transform.position.z > _topBound) {
            Destroy(gameObject);
        } else if (transform.position.z < _bottomBound) {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
