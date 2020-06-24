using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBobo : MonoBehaviour
{

    public Transform bote;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = bote.transform.position;
    }
}
