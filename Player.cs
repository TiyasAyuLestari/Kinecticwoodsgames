using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 5f;

    void Update() {
        // Input untuk gerak kanan-kiri
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(moveInput * speed * Time.deltaTime, 0, 0));
    }

    void OnTriggerEnter2D(Collider2D other) {
        HandleCollision(other);
    // Tambahkan ini di dalam fungsi OnTriggerEnter2D atau HandleCollision
    if (other.name.Contains("Blade")) // Pastikan nama gergaji di Hierarchy ada kata "Blade"
    {
        Debug.Log("GAME OVER! Kena Gergaji!");
        Destroy(gameObject); // Bolanya hancur
        // Kamu juga bisa tambahkan SceneManager.LoadScene(0) buat restart
    }
    }

    void OnTriggerStay2D(Collider2D other) {
        HandleCollision(other);
    }

    // Kita buat satu fungsi biar kodenya rapi
    void HandleCollision(Collider2D other) {
        if (other.name == "Asset 9") {
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }

        if (other.name.Contains("Asset 7")) {
            Destroy(other.gameObject);
            Debug.Log("Kotak hancur seketika!");
        }
    }
}