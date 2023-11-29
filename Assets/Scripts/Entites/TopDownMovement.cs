using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move; // ����
    }

    private void FixedUpdate()
    {
        ApplyMovent(_movementDirection);
    }
    private void Update()
    {
        Camera.main.transform.position = new Vector3(_controller.transform.position.x, _controller.transform.position.y, -10);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovent(Vector2 direction)
    {
        direction = direction * 10;
        _rigidbody.velocity = direction;
    }
}
