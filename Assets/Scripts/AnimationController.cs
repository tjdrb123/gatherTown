using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    PlayerInputController _controller;

    private void Awake()
    {
        _controller = GetComponent<PlayerInputController>();
    }
    void Start()
    {
        _controller.OnMoveEvent += AnimState;
    }
    private void AnimState(Vector2 direction)
    {
        _anim.SetBool("walk", direction.magnitude > 0); // ��, �������� ���� �� true �ƴϸ� false
    }
}
