using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKey : MonoBehaviour
{
    public GameObject Cohete;
    public GameObject Derecha;
    public GameObject Izquierda;

    void Start()
    {
        Cohete.SetActive(false);
        Derecha.SetActive(false);
        Izquierda.SetActive(false);
    }
    void Update()
    {
        particula = Cohete.GetComponent<Particle>();
        particulaDerecha = Derecha.GetComponent<Particle>();
        particulaIzquierda = Izquierda.GetComponent<Particle>();
        if(Input.GetKey("up"))
        {
            Cohete.SetActive(true);
            //particula.gameObject.SetActive(true);
        }
        else if (Input.GetKeyUp("up"))
        {
            Cohete.SetActive(false);
        }
        if(Input.GetKey("left"))
        {
            Izquierda.SetActive(true);
        }
        else if (Input.GetKeyUp("left"))
        {
            Izquierda.SetActive(false);
        }
        if(Input.GetKey("right"))
        {
            Derecha.SetActive(true);
        }
        else if (Input.GetKeyUp("right"))
        {
            Derecha.SetActive(false);
        }
    }
}
