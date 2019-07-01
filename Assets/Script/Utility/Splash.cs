using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Splash : MonoBehaviour
{
    public GameObject splash1 = null;
    public GameObject splash2 = null;
    [HideInInspector]
    public float carga;
    [SerializeField]
    private float velCarga;
    private float x=0;
    private float y=0;
    private int state;
    void Start()
    {
        x = splash1.transform.localScale.x;
        y = splash1.transform.localScale.y;
        state = 0;
    }
    void Update()
    {
        carga = carga + (Time.deltaTime * velCarga);
        switch (state)
        {
            case 0:
                SumScale();
                break;
            case 1:
                DecScale();
                break;
            case 2:
                SumScale();
                break;
            case 3:
                DecScale();
                break;
            case 4:
                SceneManager.LoadScene("Menu");
                break;
        }
        if (state == 0 || state == 1)
            splash1.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(x, y);
        else
        { 
            splash2.SetActive(true);
            splash1.SetActive(false);
            splash2.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(x, y);
        }
        if (carga >= 40 || carga < 0)
        {
           carga = 0;
           state++; 
         }
       
    }
    void SumScale()
    {
        x += carga / 10;
        y += carga / 10;
    }
    void DecScale()
    {
        x -= carga / 10;
        y -= carga / 10;
    }
}
