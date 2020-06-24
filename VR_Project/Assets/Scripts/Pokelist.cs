using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokelist")]
public class Pokelist : ScriptableObject
{
    public List<string> poke;
    public int maxPoke;
}
