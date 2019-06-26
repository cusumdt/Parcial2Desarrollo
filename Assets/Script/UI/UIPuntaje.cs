using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIPuntaje : MonoBehaviour
{
    private Text puntaje;
    // Start is called before the first frame update
    void Start()
    {
        puntaje = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        puntaje.text = "Puntaje: " + GameManager.Instance.GetScore(); 
    }
}
