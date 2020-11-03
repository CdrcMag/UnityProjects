using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    private void Start()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        if(renderer)
        {
            if (GameState.Instance.isRunning)
                renderer.material.color = Color.green;
            else
                renderer.material.color = Color.red;
        }
        
    }

}
