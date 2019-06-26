using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Scrollbar darkMater;
    public Scrollbar speedV;
    public Scrollbar speedH;
    public Text pAlt;
    public Text puntaje;
    private Nave nave;
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        nave = objeto.GetComponent<Nave>();
    }

    // Update is called once per frame
    void Update()
    {
        float carga = nave.GetDarkMater() * 10;
        darkMater.size = carga / 100;
        Vector2 actualVelocity = nave.GetActualVelocity();
        speedV.size = actualVelocity.y;
        speedH.size= actualVelocity.x;
        pAlt.text = (10f + nave.GetAltitud()).ToString();
        puntaje.text = GameManager.Instance.GetScore().ToString();
    }
}
