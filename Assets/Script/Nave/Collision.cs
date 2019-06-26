using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private Nave nave;
    public GameObject objeto;
    void Start()
    {
        nave = objeto.GetComponent<Nave>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Terreno")
        {
            GameManager.Instance.AddScore(20);
            nave.SetCollision(true);
        }
        if(col.gameObject.tag == "TerrenoGrande")
        {
            GameManager.Instance.AddScore(5);
            nave.SetCollision(true);
        }
        if(col.gameObject.tag == "Montana")
        {
            nave.SetCollisionMontana(true);
        }
    }
}
