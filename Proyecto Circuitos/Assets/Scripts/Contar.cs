using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contar : MonoBehaviour
{
    public Text Contador;
    float xp = 0.0f;
    public bool Primera = false;
    public bool Segunda = false;
    public bool Tercera = false;
    public bool Cuarta = false;
    public bool Preventivas = false;
    public bool Iniciando = false;
    public bool Detener = false;
    public Color colorDigito = Color.green;
    public Color activoRojo = Color.black;
    public Color activoAmarillo = Color.black;
    public Color activoVerde = Color.black;
    public bool siguiente = false;
    public float p;
    public float f;
    // Start is called before the first frame update
    void Start()
    {

        Contador = GetComponent<Text>();
        Contador.color = Color.red;
        colorDigito = Color.red;
        activoRojo = Color.red;
    }


    // Update is called once per frame
    void Update()
    {


        if (Primera)
        {
            Iniciando = false;
            xp += (Time.deltaTime / p) + f;

            if (xp >= 11f)
            {
                colorDigito = Color.green;
                Contador.color = Color.green;
                activoRojo = Color.black;
                activoAmarillo = Color.black;
                activoVerde = Color.green;
                xp = 1;
                Primera = false;
                Segunda = true;
            }
            else if (xp > 10.5f)
            {
                colorDigito = Color.black;
                Contador.color = Color.black;
                activoRojo = Color.black;
                activoAmarillo = Color.black;
                activoVerde = Color.black;
            }
        }
        if (Segunda)
        {
            xp += (Time.deltaTime / p) + f;
            if ((Mathf.Floor(xp) + 1) - xp >= 0.5f)
            {
                Contador.color = Color.green;
                colorDigito = Color.green;
                activoRojo = Color.black;
                activoAmarillo = Color.black;
                activoVerde = Color.green;
            }
            else
            {
                colorDigito = Color.black;
                Contador.color = Color.black;
                activoRojo = Color.black;
                activoAmarillo = Color.black;
                activoVerde = Color.black;
            }
            if (Mathf.Floor(xp) == 4f)
            {
                xp = 1;
                Segunda = false;
                Tercera = true;
                Contador.color = Color.yellow;
                colorDigito = Color.yellow;
                activoRojo = Color.black;
                activoAmarillo = Color.yellow;
                activoVerde = Color.black;
            }
            else if (xp > 3.5f)
            {
                colorDigito = Color.black;
                Contador.color = Color.black;
                activoRojo = Color.black;
                activoAmarillo = Color.black;
                activoVerde = Color.black;
            }
        }
        if (Tercera)
        {
            xp += (Time.deltaTime / p) + f;

            if (Mathf.Floor(xp) == 4)
            {
                xp = 1;
                Tercera = false;
                Cuarta = true;
                Contador.color = Color.red;
                colorDigito = Color.red;
                activoRojo = Color.red;
                activoAmarillo = Color.black;
                activoVerde = Color.black;

                siguiente = true;

            }
            else if (xp > 3.5f)
            {
                colorDigito = Color.black;
                Contador.color = Color.black;
                activoRojo = Color.black;
                activoAmarillo = Color.black;
                activoVerde = Color.black;
            }
        }
        if (Cuarta)
        {


            xp += (Time.deltaTime / p) + f;


            if (Mathf.Floor(xp) == 3)
            {
 
                xp = 1;
                Cuarta = false;
                Primera = true;
                Contador.color = Color.green;
                colorDigito = Color.green;
                activoRojo = Color.black;
                activoAmarillo = Color.black;
                activoVerde = Color.green;

            }
            else if (xp > 3.5f)
            {
                colorDigito = Color.black;
                Contador.color = Color.black;
                activoRojo = Color.black;
                activoAmarillo = Color.black;
                activoVerde = Color.black;

            }


        }
        if (Preventivas)
        {
            Primera = false;
            Segunda = false;
            Tercera = false;
            Cuarta = false;
            xp += (Time.deltaTime / p) + f;
            if (xp > 1)
            {
                xp = 0;
            }
            if ((Mathf.Floor(xp) + 1) - xp >= 0.5f)
            {

                Contador.color = Color.yellow;
                colorDigito = Color.yellow;
                activoRojo = Color.black;
                activoAmarillo = Color.yellow;
                activoVerde = Color.black;
            }
            else
            {
                colorDigito = Color.black;
                Contador.color = Color.black;
                activoRojo = Color.black;
                activoAmarillo = Color.black;
                activoVerde = Color.black;
            }

        }


        if (Detener)
        {
            Contador.color = Color.red;
            colorDigito = Color.red;
            activoRojo = Color.red;
            activoAmarillo = Color.black;
            activoVerde = Color.black;
            Primera = false;
            Segunda = false;
            Tercera = false;
            Cuarta = false;
            Preventivas = false;
            Iniciando = false;
            Detener = false;
            xp = 0;
        }
        if (Iniciando)
        {
            Contador.color = Color.green;
            colorDigito = Color.green;
            activoRojo = Color.black;
            activoAmarillo = Color.black;
            activoVerde = Color.green;
            Primera = true;
            Segunda = false;
            Tercera = false;
            Cuarta = false;
            Preventivas = false;
            Iniciando = false;
            Detener = false;
            xp = 1;
        }

        Contador.text = Mathf.Floor(xp) + "";
    }
}
