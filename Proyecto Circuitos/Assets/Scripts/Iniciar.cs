using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iniciar : MonoBehaviour
{
    // Start is called before the first frame update
    public Contar cntContador;
    public Semaforo primero;
    public Semaforo segundo;
    public Semaforo tercero;
    public Semaforo cuarto;
    public void Inicio()
    {
        cntContador.Iniciando = true;
        primero.Activo = true;
        segundo.Activo = false;
        tercero.Activo = true;
        cuarto.Activo = false;
    }

    void FixedUpdate()
    {
        if (cntContador.siguiente)
        {            
            cntContador.siguiente = !cntContador.siguiente;
            if (primero.Activo)
            {
                primero.Activo = false;
                tercero.Activo = false;
                segundo.Activo = true;
                cuarto.Activo = true;
            } 
            else if (segundo.Activo)
            {
                primero.Activo = true;
                tercero.Activo = true;
                segundo.Activo = false;
                cuarto.Activo = false;
            }

        }
    }
}
