using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperLim = 30f;
    private float lowerLim = -10f;

    // Update is called once per frame
    void Update()
    {
        // Bala fallida
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }

        // Animal cruza el limite inferior
        if (transform.position.z < lowerLim)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
