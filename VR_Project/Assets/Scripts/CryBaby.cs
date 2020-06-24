using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryBaby : MonoBehaviour
{

    public AudioSource cry;
    // Start is called before the first frame update
   

    public void LancaOcry()
    {
        cry.Play();
    }


}
