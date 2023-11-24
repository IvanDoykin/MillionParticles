using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private const float _speed = 2f;

    [SerializeField] private KeyCode _forward;
    [SerializeField] private KeyCode _backward;
    [SerializeField] private KeyCode _right;
    [SerializeField] private KeyCode _left;

    private void Update()
    {
        if (Input.GetKey(_forward))
        {
            transform.position += _speed * Time.deltaTime * transform.forward;
        }
        if (Input.GetKey(_backward))
        {
            transform.position -= _speed * Time.deltaTime * transform.forward;
        }

        if (Input.GetKey(_right))
        {
            transform.position += _speed * Time.deltaTime * transform.right;
        }
        if (Input.GetKey(_left))
        {
            transform.position -= _speed * Time.deltaTime * transform.right;
        }
    }
}
