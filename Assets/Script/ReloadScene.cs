using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public float threshold;

    private void FixedUpdate()
    {
        if (transform.position.y >  threshold)
        {
            transform.position = new Vector3(-7.71f,0f,0f);
        }
    }
}
