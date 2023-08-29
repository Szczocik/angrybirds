using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float force = 5f;
    [SerializeField] Transform pivot;

    Camera cam;
    Rigidbody rb;
    LineRenderer lineRenderer;

    Vector3 tempPos;
    Vector3 dir;
    Vector3 startPos;

    bool canBeMoved = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        lineRenderer = GetComponent<LineRenderer>();
    }
    void Start()
    {
        cam = Camera.main;
        startPos = transform.position;
        lineRenderer.SetPosition(0, pivot.position);
        lineRenderer.SetPosition(1, transform.position);
        RotatePlayer();
    }

    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        tempPos = cam.ScreenToWorldPoint(Input.mousePosition); // zamieniamy pozycj� kursora myszy (piksel) na pozycj� w �wiecie (liczby)
        tempPos.z = 0f; // camera ustawiona jest standardowo na z = -10 i dlatego musimy to zmieni� na 0
        transform.position = tempPos;
        lineRenderer.SetPosition(1, tempPos);
        RotatePlayer();
    }

    private void OnMouseUp()
    {
        lineRenderer.SetPosition(1, pivot.position);
    }

    void RotatePlayer()
    {
        Vector3 diff = transform.position - pivot.position;
        diff.Normalize();
        float rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f,0f, rotZ + 90f);
    }
}
