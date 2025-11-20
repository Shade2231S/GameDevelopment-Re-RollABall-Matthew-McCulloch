using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public TMP_Dropdown resdropdown;
    public Toggle fullscreentoggle;
    Resolution[] allresolutions;
    bool isfullscreen;
    int selectedresolution;
    List<Resolution> selectresolutionlist = new List<Resolution>();
    public void Start()
    {
        isfullscreen = true;
        allresolutions = Screen.resolutions;
        List<string> resolutionstringlist = new List<string>();
        string newres;
        foreach (Resolution res in allresolutions)
        {
            newres = res.width.ToString() + "x" + res.height.ToString();
            if (!resolutionstringlist.Contains(newres))
            {
                resolutionstringlist.Add(newres);
                selectresolutionlist.Add(res);
            }
        }
        resdropdown.AddOptions(resolutionstringlist);
    }
    public void ChangeRes()
    {
        selectedresolution = resdropdown.value;
        Screen.SetResolution(selectresolutionlist[selectedresolution].width, selectresolutionlist[selectedresolution].height, isfullscreen);
    }
    public void ChangeFullscreen()
    {
        isfullscreen = fullscreentoggle.isOn;
        Screen.SetResolution(selectresolutionlist[selectedresolution].width, selectresolutionlist[selectedresolution].height, isfullscreen);
    }
    public void Level1()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Level2()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Qwit()
    {
        Application.Quit();
    }
}
