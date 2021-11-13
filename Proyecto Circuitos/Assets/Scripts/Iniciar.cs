using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iniciar : MonoBehaviour
{
    // Start is called before the first frame update
    public Contar boolBoy;
    public Semaforo primero;
    public Semaforo segundo;
    public Semaforo tercero;
    public Semaforo cuarto;
    public void Inicio()
    {
        boolBoy.Iniciando = true;
        primero.Activo = true;
        segundo.Activo = false;
        tercero.Activo = true;
        cuarto.Activo = false;
    }

    void FixedUpdate()
    {
        if (boolBoy.siguiente)
        {
            
            boolBoy.siguiente = !boolBoy.siguiente;

            if (primero.Activo)
            {
                primero.Detener();
                tercero.Detener();
                primero.Activo = false;
                tercero.Activo = false;
                segundo.Activo = true;
                cuarto.Activo = true;

            } else
            if (segundo.Activo)
            {
                tercero.Detener();
                cuarto.Detener();
                primero.Activo = true;
                tercero.Activo = true;
                segundo.Activo = false;
                cuarto.Activo = false;

            }

        }
    }
}
