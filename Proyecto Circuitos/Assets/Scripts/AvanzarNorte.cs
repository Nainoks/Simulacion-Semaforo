using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AvanzarNorte : MonoBehaviour
{
    public Rigidbody2D autoRigidbody;
    public float velocidad;
    float velocidadAnterior;
    public GameObject destino;
    public GameObject inicio;
    public Sprite CarroBlancoP;
    public Sprite CarroBlancoD;
    public Sprite CarroCafeP;
    public Sprite CarroCafeD;
    public Sprite CarroVerdeP;
    public Sprite CarroVerdeD;
    public Sprite TaxiP;
    public Sprite TaxiD;
    public Sprite pato;

    // Start is called before the first frame update

    public void Awake()
    {
        autoRigidbody = GetComponent<Rigidbody2D>();

        velocidadAnterior = velocidad;
    }
    void Start()
    {
        SpriteRandom();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bloqueo") // or if(gameObject.CompareTag("YourWallTag"))
        {
            velocidadAnterior = velocidad;
            velocidad = 0;
        }
   
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bloqueo") // or if(gameObject.CompareTag("YourWallTag"))
        {
            velocidad = velocidadAnterior;
        }

    }
    // Update is called once per frame
    void Update()
    {
        float xForce = velocidad * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, destino.transform.position, xForce);
        if (transform.position == destino.transform.position)
        {

            SpriteRandom();
        }
        
    }
    void SpriteRandom() {
        int randomInt = Random.Range(39, 50);
        velocidad = Random.Range(2, 6);
        var direccion = transform.position - inicio.transform.position;
        this.transform.position = inicio.transform.position;
        if (randomInt == 40)
        {

            if (direccion.y > 0)
            {

                this.gameObject.GetComponent<SpriteRenderer>().sprite = CarroBlancoP;
            }
            else
            {

                this.gameObject.GetComponent<SpriteRenderer>().sprite = CarroBlancoD;
            }

        }
        if (randomInt == 41)
        {
            if (direccion.y > 0)
            {

                this.gameObject.GetComponent<SpriteRenderer>().sprite = CarroCafeP;
            }
            else
            {

                this.gameObject.GetComponent<SpriteRenderer>().sprite = CarroCafeD;
            }
        }
        if (randomInt == 42)
        {
            if (direccion.y > 0)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = TaxiP;

            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = TaxiD;

            }
        }
        if (randomInt == 44)
        {
            if (direccion.y > 0)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = CarroVerdeP;
            }
            else
            {

                this.gameObject.GetComponent<SpriteRenderer>().sprite = CarroVerdeD;
            }

        }
        if (randomInt == 45)
        {
            if (direccion.y > 0)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = CarroVerdeP;
            }
            else
            {

                this.gameObject.GetComponent<SpriteRenderer>().sprite = CarroVerdeD;
            }

        }
    }
}
