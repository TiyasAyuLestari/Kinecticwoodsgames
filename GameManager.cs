using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Pastikan ini 'public' agar bisa diisi di Inspector
    public GameObject panelGameOver; 

    void Start()
    {
        // Pastikan saat mulai game, panelnya mati dulu
        if (panelGameOver != null) 
            panelGameOver.SetActive(false);
    }

    public void MunculkanGameOver()
    {
        Debug.Log("Fungsi MunculkanGameOver dipanggil!"); // Cek di Console
        if (panelGameOver != null)
        {
            panelGameOver.SetActive(true); // Ini perintah kuncinya
            Time.timeScale = 0f; // Menghentikan waktu game
        }
        else
        {
            Debug.LogError("Waduh! Slot panelGameOver di ManagerObject masih KOSONG!");
        }
    }

    public void KlikRestart()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}