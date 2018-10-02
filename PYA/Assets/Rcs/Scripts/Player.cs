using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private bool _isMoving = false;

    private void Update()
    {
        if (_isMoving == true)
        {
            transform.localPosition += Vector3.right * 250.0f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition += Vector3.right * 10.0f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition += Vector3.left * 10.0f * Time.deltaTime;
        }
    }

    public void DebugGoRight()
    {
        _isMoving = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Objective")
        {
            FinishLevel();
        }
    }

    private void FinishLevel()
    {
        Debug.Log(gameObject + " : objective FOUND !");

        _isMoving = false;
    }
}
