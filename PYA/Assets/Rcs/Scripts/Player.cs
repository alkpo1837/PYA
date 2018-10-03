using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [Header("DBG")]
    public float DBGMoveValue = 50.0f;

    private Rigidbody _rigidbody;
    private bool _isMoving = false;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition += Vector3.right * DBGMoveValue * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += Vector3.left * DBGMoveValue * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gameObject + " Trigger ented = " + other.name);

        if (other.tag == "Objective")
        {
            FinishLevel();
        }
    }

    private void FinishLevel()
    {
        Debug.Log(gameObject + " : objective FOUND !");
    }

    public void PlayAction(IAction action)
    {
        action.Play(this);
    }
}
