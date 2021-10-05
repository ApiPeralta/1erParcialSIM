using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetSceneByName("LevelPaint") == SceneManager.GetActiveScene())
        {
            transform.Rotate(-90, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
