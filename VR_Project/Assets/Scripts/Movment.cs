using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Movment : MonoBehaviour
{
    
    Vector3 dir;
    public float speed;
    RaycastHit hit;
    public Image[] images;
    public Pokelist pokelist;

    // Start is called before the first frame update
    void Start()
    {
        pokelist.poke.Clear();

    }

    // Update is called once per frame
    void Update()
    {
      // Move();

        Pointer();
        //transform.position += transform.forward *Time.deltaTime;
    }

    void Move()
    {
        dir = Input.GetAxisRaw("Horizontal") * transform.right;
        dir += Input.GetAxisRaw("Vertical") * transform.forward;
        transform.position += dir *Time.deltaTime * speed ;
        //transform.Translate(dir);
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
}
