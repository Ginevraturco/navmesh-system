using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CharacterController))]
public class SkeletonController: MonoBehaviour
{
    CharacterController _controller;

    public float speed = 4;
    public float rotationSpeed = 4;

    public CinemachineVirtualCamera secondaryCamera;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        var activateCamera = Input.GetButton("Fire1");
        secondaryCamera.gameObject.SetActive(activateCamera);

        var hMove = Input.GetAxis("Horizontal");
        var rotation = rotationSpeed * hMove;
        var rotVector = new Vector3(0, rotation, 0);
        transform.Rotate(rotVector);

        var forward =
            transform.TransformDirection(Vector3.forward);
        var vMove = Input.GetAxis("Vertical");
        vMove = Mathf.Clamp(vMove, 0, 1);
        var currentSpeed = rotationSpeed * vMove;
        var move = currentSpeed * forward;
        _controller.SimpleMove(move);
    }
}
