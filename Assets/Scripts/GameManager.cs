using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Devil;
    public GameObject[] Spear;
    public GameObject[] Earth;
    public GameObject[] Things;

    public GameObject Warn;
    public bool Clickable;
    public int cnt;
    
    public void WarnStart()
    {
        Warn.SetActive(true);
    }
}
