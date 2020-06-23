using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barquinho : MonoBehaviour
{
    CharacterController CC;
    public float vel = 3;
    public float distance_ate_o_proximo_ponto;
    public Vector3 movimento;

    int progresso;
    public GameObject[] pontos;

    // Start is called before the first frame update
    void Start()
    {
        progresso = 0;
        CC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        distance_ate_o_proximo_ponto = Vector3.Distance(gameObject.transform.position, pontos[progresso].transform.position);

        if(distance_ate_o_proximo_ponto <= 20)
        {
            progresso++;
        }
        movimento.z = 0;
        movimento.x = vel * Time.deltaTime;

        transform.LookAt(pontos[progresso].transform.position);


        CC.Move(transform.forward * Time.deltaTime);
    }
}
