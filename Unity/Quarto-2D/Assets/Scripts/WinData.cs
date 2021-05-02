using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinData : MonoBehaviour
{
    public int playerWin = 0;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
