using UnityEngine;

public class MuterAnteng : MonoBehaviour {
    public float kecepatan = 300f;

    void Update() {
        // Kode ini memaksa gergaji muter di titik tengah dirinya sendiri
        transform.Rotate(0, 0, kecepatan * Time.deltaTime, Space.Self);
    }
}