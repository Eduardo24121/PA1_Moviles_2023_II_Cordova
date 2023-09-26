using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public float cantidadPuntos;
    public  Puntaje puntaje;
    public float speed = 2f;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }
    }
    private void Update()
    { 
        Vector3 position = transform.position;
        position.x -= speed * Time.deltaTime;
        transform.position = position;
    }
}
