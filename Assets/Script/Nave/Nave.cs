using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Nave : Singleton<Nave>
{
    const float topZ = 5f;
    const float minZ=355f;
    const float topVelocity = -1;
    const float initDarkMater = 50;
    // Start is called before the first frame update
    public bool colision = false;
    public bool colisionMontana = false;
    public Quaternion rot;
    public float z;
    public Vector2 actualVelocity;
    public GameObject explosion;
    public float darkMater;
    [SerializeField]
    private Sprite naveQuemada;
    [SerializeField]
    private Sprite naveTomas;
    // Update is called once per frame
    
    void Update()
    {
        StateCollision();
        StateDarkMater();
    }
    
    public void StateDarkMater()
    {
        if(darkMater <= 0)
        {
            GameObject naveActual = this.gameObject;
            Debug.Log("explote");
            explosion.SetActive(true);
            explosion.transform.position = new Vector3 (naveActual.transform.position.x,naveActual.transform.position.y,naveActual.transform.position.z-2.0f);
            naveActual.GetComponent<SpriteRenderer>().sprite=naveQuemada;
            StartCoroutine("ifDead");
        }
    }
    public void StateCollision()
    {
        z=transform.eulerAngles.z;
        if(limitRotation()&&limitVelocity()) 
        {
             Debug.Log("Gane");
             colision = false;
             colisionMontana = false;
             StartCoroutine("ifWin");
        }
        else if(colision || colisionMontana)
        {
         
            GameObject naveActual = this.gameObject;
            explosion.SetActive(true);
            explosion.transform.position = new Vector3 (naveActual.transform.position.x,naveActual.transform.position.y,naveActual.transform.position.z-2.0f);
            naveActual.GetComponent<SpriteRenderer>().sprite=naveQuemada;
            StartCoroutine("ifDead");
            
        }
         rot = Quaternion.Euler(transform.rotation.x,transform.rotation.y,transform.rotation.z);

    }
    private bool limitVelocity()
    {
        return (actualVelocity.y > topVelocity && actualVelocity.y < 0.0f);
    }
    private bool limitRotation()
    {
        return ((z < topZ || z > minZ) && colision == true);
    }
    public void SetActualVelocity(Vector2 _actualVelocity)
    {
        actualVelocity = _actualVelocity;
    }
    public Vector2 GetActualVelocity()
    {
        return actualVelocity;
    }
    public void SetCollision(bool _colision)
    {
        colision = _colision;
    }
    public bool GetCollision()
    {
        return colision;
    }
    public void SetCollisionMontana(bool _colision)
    {
        colisionMontana = _colision;
    }
    public bool GetCollisionMontana()
    {
        return colisionMontana;
    }
    public void SustDarkMater(float _darkMater)
    {
        darkMater-=_darkMater;
    }
    public float GetDarkMater()
    {
        return darkMater;
    }
    public float GetAltitud()
    {
        return this.transform.position.y;
    }
    IEnumerator ifDead()
    {
        yield return new WaitForSeconds(2.0f);
        colision = false;
        colisionMontana = false;
        GameObject naveActual = this.gameObject;
        naveActual.GetComponent<SpriteRenderer>().sprite=naveTomas;
        darkMater = initDarkMater;
        GameManager.Instance.AddScore(-10);
        SceneManager.LoadScene("Aterrizaje");
    }
    IEnumerator ifWin()
    {
       yield return new WaitForSeconds(2.0f); 
       SceneManager.LoadScene("Aterrizaje");
    }
}
