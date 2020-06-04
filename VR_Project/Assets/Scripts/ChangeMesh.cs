using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMesh : MonoBehaviour
{
    private MeshFilter mesh;
    public Mesh awake;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshFilter>();
        mesh.mesh = awake;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
