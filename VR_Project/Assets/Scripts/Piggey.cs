using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piggey : MonoBehaviour
{

    CharacterController CC;
    public GameObject[] caminho;
    public float vel;
    public float distance_ate_o_proximo_ponto;
    public Vector3 movimento;

    int progresso;

    // Start is called before the first frame update
    void Start()
    {
        progresso = 0;
        CC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        distance_ate_o_proximo_ponto = Vector3.Distance(gameObject.transform.position, caminho[progresso].transform.position);

        if (distance_ate_o_proximo_ponto <= 20)
        {
            if(progresso <= 6)
            {
                progresso++;
            }
            else
            {
                progresso = 0;
            }
          
        }
        movimento.z = vel * Time.deltaTime;
        movimento.x = 0;

        transform.LookAt(caminho[progresso].transform.position);


        CC.Move(transform.forward * Time.deltaTime * vel);
    }
}
