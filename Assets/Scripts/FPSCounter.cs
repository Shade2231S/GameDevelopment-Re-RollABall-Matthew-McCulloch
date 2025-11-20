using UnityEngine;
using TMPro;
public class FPSCounter : MonoBehaviour
{   public TextMeshProUGUI fpstext;
    public float pullingtime = 0.8f;
    public float time;
    public float framecount;
    void Update()
    {
        time += Time.deltaTime;
        framecount++;
        if(time >= pullingtime)
        {
            int framerate = Mathf.RoundToInt(framecount / time);
            fpstext.text = framecount.ToString() + " FPS";
            time += pullingtime;
            framecount = 0;
        }
    }
}
