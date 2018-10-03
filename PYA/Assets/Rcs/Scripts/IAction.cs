using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAction : MonoBehaviour
{
    public delegate void ActionCallback();

    public event ActionCallback OnStarted = null;
    public event ActionCallback OnFinished = null;
    public event ActionCallback OnAborted = null;

    protected Player _player;

    protected bool _isPlaying = false;

    public virtual void Play(Player player)
    {
        _player = player;
        
        if (OnStarted != null)
            OnStarted();

        _isPlaying = true;
    }

    public virtual void Finish()
    {
        if (OnFinished != null)
            OnFinished();

        _isPlaying = false;
    }
}
