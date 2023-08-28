using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Camera cam;
    Vector3 tempPos;

    private void Awake()
    {
        
    }
    void Start()
    {
        cam = Camera.main;    
    }

    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        tempPos = cam.ScreenToWorldPoint(Input.mousePosition); // zamieniamy pozycjê kursora myszy (piksel) na pozycjê w œwiecie (liczby)
        tempPos.z = 0f; // camera ustawiona jest standardowo na z = -10 i dlatego musimy to zmieniæ na 0
        transform.position = tempPos;
    }
}
