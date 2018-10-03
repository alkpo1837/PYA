using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionMove : IAction
{
    [Header("Values")]
    public Vector3 Direction;
    public float Speed;
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
            _player.transform.localPosition += Direction * Speed * Time.deltaTime;

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
