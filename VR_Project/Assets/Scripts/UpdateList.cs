using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateList : MonoBehaviour
{

    public TMPro.TextMeshProUGUI lista;
    public TMPro.TextMeshProUGUI porcentagem;
    public Pokelist poke;
    private string a;
    private float x;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = "Capturados:\n";
        foreach (string p in poke.poke)
        {
            a += p + "\n";
        }
        lista.text = a;

        x = ( (float) poke.poke.Count /(float) poke.maxPoke ) * 100.0f;

        Debug.Log(x);

        porcentagem.text = x.ToString() + "%";
    }
}
