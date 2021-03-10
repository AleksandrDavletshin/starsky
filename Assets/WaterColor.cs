using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var colorobjects = GetComponentsInChildren<SpriteRenderer>();

        Debug.Log(colorobjects.Length);

        for (int i = 0; i < colorobjects.Length; i++)
        {
            colorobjects[i].color = Color.cyan;
        }
    }
}
