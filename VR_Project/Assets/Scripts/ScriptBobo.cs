using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBobo : MonoBehaviour
{

    public Transform bote;

    public Vector3 posicao;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        seguirBarquinho();
    }

    void seguirBarquinho()
    {
        posicao.x = bote.position.x;
        posicao.z = bote.position.z;
        posicao.y = transform.position.y;

        gameObject.transform.position = posicao;
    }
}
