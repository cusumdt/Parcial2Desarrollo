using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKey : MonoBehaviour
{
    public GameObject Cohete;
    public GameObject Derecha;
    public GameObject Izquierda;

    Particle particula;
    Particle particulaDerecha;
    Particle particulaIzquierda;
    
    void Update()
    {
        particula = Cohete.GetComponent<Particle>();
        particulaDerecha = Derecha.GetComponent<Particle>();
        particulaIzquierda = Izquierda.GetComponent<Particle>();
        if(Input.GetKey("up"))
        {
            particula.on = true;
        }
        else
        {
            particula.on = false;
        }
        if(Input.GetKey("left"))
        {
            particulaIzquierda.on = true;
        }
        else
        {
            particulaIzquierda.on = false;
        }
        if(Input.GetKey("right"))
        {
            particulaDerecha.on = true;
        }
        else
        {
            particulaDerecha.on = false;
        }
    }
}
