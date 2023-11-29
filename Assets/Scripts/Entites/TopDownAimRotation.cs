using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim; // ±¸µ¶
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateCharacter(newAimDirection);
    }

    private void RotateCharacter(Vector2 direction)
    {
        if (direction.x < 0)
        {
            characterRenderer.flipX = true;       
        }
        else
        {
            characterRenderer.flipX = false;
        }

        //float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}