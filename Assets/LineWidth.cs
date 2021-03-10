using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineWidth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		GetComponent<LineRenderer>().SetWidth(0.01f,0.01f);   
    }
}
