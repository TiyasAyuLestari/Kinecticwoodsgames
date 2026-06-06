using UnityEngine;
using UnityEngine.SceneManagement; // Ini wajib ada di paling atas!
public class Akhir : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("SAYA SUDAH KENYENTUH PINTU!"); // Tambahkan ini
            SceneManager.LoadScene("Level 6"); 
        }
    }
}
