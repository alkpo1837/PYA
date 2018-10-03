using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionWait : IAction
{
    [Header("Values")]
    public float Duration;

    protected float _elapsedTime = 0.0f;

    public override void Play(Player player)
    {
        base.Play(player);
    }

    public void Update()
    {
        if (_isPlaying)
        {
            if (_elapsedTime >= Duration)
            {
                Finish();
            }

            _elapsedTime += Time.deltaTime;
        }
    }

    public override void Finish()
    {
        base.Finish();
    }
}
