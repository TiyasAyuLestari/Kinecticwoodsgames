using UnityEngine;

public class GerakNaikTurun : MonoBehaviour {
    [Header("Pengaturan Gerak")]
    public float jarak = 0.5f;   // Seberapa jauh dia naik & turun
    public float kecepatan = 2f; // Seberapa cepat ayunannya
    
    [Header("Titik Tengah")]
    public float offsetVertical = 0f; // Geser posisi "pusat" ayunannya

    float posisiAwalY;

    void Start() {
        // Catat posisi Y saat kamu taruh di Scene
        posisiAwalY = transform.position.y;
    }

    void Update() {
        // Mathf.Sin bakal bikin gerakan naik turun yang halus
        // Kita tambah offsetVertical biar kamu bisa geser pusatnya ke atas/bawah
        float baruY = (posisiAwalY + offsetVertical) + Mathf.Sin(Time.time * kecepatan) * jarak;
        
        transform.position = new Vector3(transform.position.x, baruY, transform.position.z);
    }
}