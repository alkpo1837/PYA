using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [Header("References")]
    public Player PlayerI;

    [Header("Elements")]
    public UIWidget PlayButton;

    private void Start()
    {
        UIEventListener.Get(PlayButton.gameObject).onClick = ClickOnPlayButton;
    }

    private void ClickOnPlayButton(GameObject go)
    {
        PlayerI.DebugGoRight();
    }
}
