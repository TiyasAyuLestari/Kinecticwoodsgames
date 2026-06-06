using UnityEngine;

public class BahayaGergaji : MonoBehaviour
{
    // Fungsi ini jalan kalau Is Trigger TIDAK dicentang
    void OnCollisionEnter2D(Collision2D collision)
    {
        CekPemain(collision.gameObject);
    }

    // Fungsi ini jalan kalau Is Trigger DICENTANG
    void OnTriggerEnter2D(Collider2D other)
    {
        CekPemain(other.gameObject);
    }

    void CekPemain(GameObject objek)
    {
        if (objek.CompareTag("Player"))
        {
            Debug.Log("Bola kena gergaji!");
            GameManager manager = FindFirstObjectByType<GameManager>();
            if (manager != null)
            {
                manager.MunculkanGameOver();
            }
        }
    }
}