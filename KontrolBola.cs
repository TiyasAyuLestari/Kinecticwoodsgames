using UnityEngine;

public class KontrolBola : MonoBehaviour {
    public float kecepatan = 5f;
    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        // Mengambil input dari panah keyboard atau WASD
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Ganti bagian rb.velocity dengan ini
rb.linearVelocity = new Vector2(moveX, moveY).normalized * kecepatan;
    }
}