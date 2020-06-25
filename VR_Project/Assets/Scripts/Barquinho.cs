using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barquinho : MonoBehaviour
{
    CharacterController CC;
    public float vel;
    public float distance_ate_o_proximo_ponto;
    public Vector3 movimento;

    bool possoAndar = false;
    int progresso;
    public GameObject[] pontos;


    //public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        progresso = 0;
        CC = GetComponent<CharacterController>();
        possoAndar = true;
    }

    // Update is called once per frame
    void Update()
    {

        //if(camera.transform.position.x == transform.position.x && camera.transform.position.z == transform.position.z)
        //{
        //    possoAndar = true;
        //}

        if(possoAndar == true && progresso != 8)
        {
            distance_ate_o_proximo_ponto = Vector3.Distance(gameObject.transform.position, pontos[progresso].transform.position);

            if (distance_ate_o_proximo_ponto <= 20)
            {
                progresso++;
            }
            movimento.z = vel * Time.deltaTime;
            movimento.x = 0;

            transform.LookAt(pontos[progresso].transform.position);


            CC.Move(transform.forward * Time.deltaTime * vel);

        }

    }
}
