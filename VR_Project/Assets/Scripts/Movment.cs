using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Movment : MonoBehaviour
{
    Vector3 dir;
    RaycastHit hit;
    public Image[] images;
    public Pokelist pokelist;

    public Transform bote;
    public Vector3 posicao;

    public GameObject quebraGalho;

    bool podeSeguir, maiorQoQuebraGalho;

    // Start is called before the first frame update
    void Start()
    {
        pokelist.poke.Clear();
        podeSeguir = false;
        maiorQoQuebraGalho = false;
    }

    // Update is called once per frame
    void Update()
    {
      // Move();
      if(transform.position.x < quebraGalho.transform.position.x)
        {
            maiorQoQuebraGalho = true;
        }

        Pointer();
        if(podeSeguir == true && maiorQoQuebraGalho == true)
        {
            SeguirBarquinho();
        }
    }


    void Pointer()
    {

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
             if(hit.collider.gameObject.tag == "Interactable")
             {               
               
                
                foreach (Image fill in images)
                {
                    fill.fillAmount +=  0.33f*Time.deltaTime;
                }

                if (images[0].fillAmount >= 1)
                {
                    if (!pokelist.poke.Contains(hit.collider.gameObject.name))
                    {
                        pokelist.poke.Add(hit.collider.gameObject.name);
                        hit.collider.gameObject.GetComponent<CryBaby>().LancaOcry();
                    }
                }

             }
             else
             {
                foreach (Image fill in images)
                {
                    fill.fillAmount = 0;
                }
            }


            if (hit.collider.gameObject.tag == "IniciarGame")
            {
             
                foreach (Image fill in images)
                {
                    fill.fillAmount += 0.33f * Time.deltaTime;
                }

                GetComponent<Animator>().enabled = true;
                podeSeguir = true;
            }
        }
        else
        {
            foreach (Image fill in images)
            {
                fill.fillAmount = 0;
            }
        }

        Debug.DrawLine(transform.position, hit.point);
    }

    void SeguirBarquinho()
    {
        GetComponent<Animator>().enabled = false;
        posicao.x = bote.position.x;
        posicao.z = bote.position.z;
        posicao.y = transform.position.y;

        gameObject.transform.position = posicao;
    }
}
