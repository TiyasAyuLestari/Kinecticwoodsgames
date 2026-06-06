using UnityEngine;

public class Tombol : MonoBehaviour {
    public GameObject pintu; // Nanti tarik pintu ke sini

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            pintu.SetActive(true); // Pintu muncul saat diinjak
            Debug.Log("Pintu Terbuka!");
        }
    }
}