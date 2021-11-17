using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detener : MonoBehaviour
{
    public Contar cntContador;
    public void Detencion()
    {
        GameObject g = GameObject.FindGameObjectWithTag("BoolKeeper");

        cntContador = g.GetComponent<Contar>();

        cntContador.Detener = true;
    }
}
