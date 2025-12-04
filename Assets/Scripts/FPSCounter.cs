using UnityEngine;
using TMPro;
public class FPSCounter : MonoBehaviour
{   public TextMeshProUGUI fpstext;
    private void Awake()
    {
        if (fpstext == null)
            fpstext = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        float fps = 1f / Time.deltaTime;
        fpstext.text = (int)fps + "FPS";
    }
}