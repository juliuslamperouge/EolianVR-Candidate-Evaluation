using Microsoft.MixedReality.Toolkit.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PointerHandler))]
public class Test : MonoBehaviour
{
    private void Start()
    {
        var pointerHandler = gameObject.GetComponent<PointerHandler>();

        pointerHandler.OnPointerDown.AddListener((e) =>
        {
            SpawnBall(e.Pointer.Position, e.Pointer.Rotation);
        });
    }

    public void SpawnBall(Vector3 pos, Quaternion rot)
    {
        var newBall = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        var ballRenderer = newBall.GetComponent<Renderer>();
        var ballRB = newBall.AddComponent<Rigidbody>();
        var ballTransform = newBall.transform;

        ballTransform.localScale = Vector3.one * 0.03f;
        ballTransform.position = pos;
        ballTransform.rotation = rot;

        ballRenderer.material.color = new(UnityEngine.Random.Range(0.5f, 1f), UnityEngine.Random.Range(0.5f, 1f), UnityEngine.Random.Range(0.5f, 1f), 1f);

        ballRB.AddForce(ballTransform.forward * 30, ForceMode.Impulse);
    }
}
