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

    public delegate void SequenceCallback();

    public event SequenceCallback OnSequenceSucceed = null;
    public event SequenceCallback OnSequenceFailed = null;

    private void Start()
    {
        UIEventListener.Get(PlayButton.gameObject).onClick = ClickOnPlayButton;
    }

    private void ClickOnPlayButton(GameObject go)
    {
        startSequence();
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            startSequence();
        }
    }

    private void startSequence()
    {
        ActionsManager.Instance.Play();
    }
}
