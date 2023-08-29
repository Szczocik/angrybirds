using System.ComponentModel;
using UnityEngine;

public class Pig : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("ground"))
        {
            GetComponentInParent<PigsManager>()
        }
    }
}
