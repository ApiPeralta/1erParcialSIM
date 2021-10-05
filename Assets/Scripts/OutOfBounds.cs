using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    void Update()
    {
        Out();
    }
    public void Out()
    {
        if (this.transform.position.x >= 10)
        {
            Destroy(this.gameObject);
        }
    }
}
