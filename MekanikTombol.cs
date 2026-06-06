using UnityEngine;

public class MekanikTombol : MonoBehaviour 
{
    public Color warnaTujuan = Color.green;
    private SpriteRenderer sr;

    void Start() {
        sr = GetComponent<SpriteRenderer>();
    }

    public void AktifkanTombol() {
        if (sr != null) sr.color = warnaTujuan;
    }
}