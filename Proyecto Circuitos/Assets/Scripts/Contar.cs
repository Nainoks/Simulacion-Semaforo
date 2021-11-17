using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contar : MonoBehaviour
{
    public Text txtContador;
    float segundos = 0.0f;
    public bool PrimeraFase = false;
    public bool SegundaFase = false;
    public bool TerceraFase = false;
    public bool CuartaFase = false;
    public bool Preventivas = false;
    public bool Iniciando = false;
    public bool Detener = false;
    public Color activoRojo = Color.black;
    public Color activoAmarillo = Color.black;
    public Color activoVerde = Color.black;
    public bool siguiente = false;
    // Start is called before the first frame update
    void Start()
    {
        txtContador = GetComponent<Text>();
        txtContador.color = Color.red;
        activoRojo = Color.red;
    }

    void EncenderVerde() {
        txtContador.color = Color.green;
        activoRojo = Color.black;
        activoAmarillo = Color.black;
        activoVerde = Color.green;
    }

    void EncenderAmarillo()
    {
        txtContador.color = Color.yellow;
        activoRojo = Color.black;
        activoAmarillo = Color.yellow;
        activoVerde = Color.black;
    }
    void EncenderRojo()
    {
        txtContador.color = Color.red;
        activoRojo = Color.red;
        activoAmarillo = Color.black;
        activoVerde = Color.black;
    }
    void ApagarSemaforo() {
        txtContador.color = Color.black;
        activoRojo = Color.black;
        activoAmarillo = Color.black;
        activoVerde = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (PrimeraFase)
        {
            segundos += Time.deltaTime;
            if (segundos <= 10.5f)//Enciende el semaforo durante los primeros 10 segundos y medio
            {
                EncenderVerde();            
            }
            else if (segundos >= 10.5f && segundos < 11f)//Apaga el semaforo por medio segundo
            {
                ApagarSemaforo();
            } 
            else if (segundos >= 11f)//Cambio a la tercera fase
            {
                segundos = 1;
                PrimeraFase = false;
                SegundaFase = true;
            }

        }
        if (SegundaFase)
        {
            segundos += Time.deltaTime;

            //Enciende el verde del semaforo durante los primeros 0.5 segundos de un segundo
            if ((Mathf.Floor(segundos) + 1) - segundos >= 0.5f)
            {
                EncenderVerde();
            }//Apaga el semaforo durante los ultimos 0.5 segundos de un segundo
            else
            {
                ApagarSemaforo();
            }
            //Cambio a la tercera fase
            if (segundos >= 4f)
            {
                segundos = 1;
                SegundaFase = false;
                TerceraFase = true;
            }

        }
        if (TerceraFase)
        {
             segundos += Time.deltaTime;
            if (segundos <= 3.5f)//Enciende el semaforo durante los primeros 10 segundos y medio
            {
                EncenderAmarillo();
            }
            else if (segundos > 3.5f && segundos < 4)//Apaga el semaforo por medio segundo
            {
                ApagarSemaforo();
            }
            else if (segundos >= 4)//Cambio a la cuarta fase
            {
                segundos = 1;
                TerceraFase = false;
                CuartaFase = true;
                //Activa la bandera de siguiente, la cual notificara al controlador principal la necesidad de un cambio
                siguiente = true;
            }
        }
        if (CuartaFase)
        {
            segundos += Time.deltaTime;
            if (segundos < 2.5f)//Enciende el semaforo durante los primeros 2 segundos y medio
            {
                EncenderRojo();
            }
            else if (segundos >= 2.5 && segundos < 3f)//Apaga el semaforo por medio segundo
            { 
                ApagarSemaforo();
            }
            else if (segundos >= 3f)//Cambio a la primera fase
            {
                segundos = 1;
                CuartaFase = false;
                PrimeraFase = true;
                EncenderVerde();
            }
        }
        if (Preventivas)
        {
            PrimeraFase = false;
            SegundaFase = false;
            TerceraFase = false;
            CuartaFase = false;
            segundos += Time.deltaTime;
            if (segundos > 1) //Reinicia el contador a 0 
            {
                segundos = 0;
            }
            //Enciende el amarillo del semaforo durante los primeros 0.5 segundos de un segundo
            if ((Mathf.Floor(segundos) + 1) - segundos <= 0.5f)
            {
                EncenderAmarillo();
            }
            else //Apaga el semaforo durante los ultimos 0.5 segundos de un segundo
            {
                ApagarSemaforo();
            }
        }
        if (Detener)
        {
            EncenderRojo();
            PrimeraFase = false;
            SegundaFase = false;
            TerceraFase = false;
            CuartaFase = false;
            Preventivas = false;
            Iniciando = false;
            Detener = false;
            segundos = 0;
        }
        if (Iniciando)
        {
            EncenderVerde();
            PrimeraFase = true;
            SegundaFase = false;
            TerceraFase = false;
            CuartaFase = false;
            Preventivas = false;
            Iniciando = false;
            Detener = false;
            segundos = 1;
        }

        txtContador.text = Mathf.Floor(segundos) + "";
    }
}
