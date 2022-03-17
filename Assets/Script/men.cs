using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class men : MonoBehaviour
{
    public GameObject nmap,old;public string mp = "https://github.com/Paulastya2007/Roll-a-ball";
    void Start()
    {
        old.SetActive(true);
        nmap.SetActive(false);
    }
    public void play() {
        SceneManager.LoadScene(1);
    }
    public void quit()
    { 
        Application.Quit();
    }
    public void ClickHere() {
        Application.OpenURL(mp);
    }
    public void crap() {
        nmap.SetActive(true);old.SetActive(false);
    }
    public void back() { old.SetActive(true); nmap.SetActive(false); }
}
