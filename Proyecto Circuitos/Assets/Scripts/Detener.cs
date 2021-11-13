using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detener : MonoBehaviour
{
    public Contar boolBoy;
    public void Detencion()
    {
        GameObject g = GameObject.FindGameObjectWithTag("BoolKeeper");

        boolBoy = g.GetComponent<Contar>();

        boolBoy.Detener = true;
    }
}
