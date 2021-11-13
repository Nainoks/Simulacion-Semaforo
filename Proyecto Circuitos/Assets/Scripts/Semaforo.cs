using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityEngine.UI;

public class Semaforo : MonoBehaviour
{
    public Contar ctrContador;
    public UnityEngine.Experimental.Rendering.Universal.Light2D sRojo;
    public UnityEngine.Experimental.Rendering.Universal.Light2D sAmarillo;
    public UnityEngine.Experimental.Rendering.Universal.Light2D sVerde;
    public BoxCollider2D Parada;
    public bool Activo;

    // Start is called before the first frame update
    void Start()
    {

        GameObject g = GameObject.FindGameObjectWithTag("BoolKeeper");
        ctrContador = g.GetComponent<Contar>();
    }

    public void Seder()
    {
        Activo = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Activo)
        {
            sVerde.color = ctrContador.activoVerde;
            sAmarillo.color = ctrContador.activoAmarillo;
            sRojo.color = ctrContador.activoRojo;

            if (ctrContador.Primera || ctrContador.Segunda)
            {
                Parada.enabled = false;
            }
            else if (ctrContador.Tercera || ctrContador.Cuarta || ctrContador.Detener || ctrContador.Preventivas || ctrContador.Iniciando)
            { Parada.enabled = true; }

        }

        if (ctrContador.Preventivas)
        {
            Preventivas();
        }
        if (ctrContador.Detener)
        {
            Detener();
        }
        if (ctrContador.Iniciando)
        {
            Iniciar();
        }

    }
    public void Iniciar() {
        sVerde.color = Color.black;
        sAmarillo.color = Color.black;
        sRojo.color = Color.red;
        Parada.enabled = true;
    }

    public void Preventivas() {
        sVerde.color = ctrContador.activoVerde;
        sAmarillo.color = ctrContador.activoAmarillo;
        sRojo.color = ctrContador.activoRojo;
        Parada.enabled = true;
    }
    public void Detener() {
        sVerde.color = Color.black;
        sAmarillo.color = Color.black;
        sRojo.color = Color.red;
        Parada.enabled = true;
    }

}
