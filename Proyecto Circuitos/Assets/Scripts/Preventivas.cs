using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preventivas : MonoBehaviour
{
    public Contar boolBoy;
    public void Prevencion()
    {
        GameObject g = GameObject.FindGameObjectWithTag("BoolKeeper");

        boolBoy = g.GetComponent<Contar>();

        boolBoy.Preventivas = true;
    }
}
