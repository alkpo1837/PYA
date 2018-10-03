using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionJump : IAction
{
    [Header("Values")]
    public Vector2 Angle;
    public float Strength;

    protected float _elapsedTime = 0.0f;

    public override void Play(Player player)
    {
        base.Play(player);

        // _player.rigidbody.AddForce(Angle * Strength, ForceMode.Impulse);
    }

    public void Update()
    {
        if (_isPlaying)
        {
            //if (_player.rigidbody.velocity == Vector3.zero)
            //{
            //    Finish();
            //}
        }
    }

    public override void Finish()
    {
        base.Finish();
    }
}
