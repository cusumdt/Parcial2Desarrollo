using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public static GameManager instance = null;
    [SerializeField]
    private int score;
     [SerializeField]
    private int nivel;

    void Awake()
    {
           if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);    
            }
            DontDestroyOnLoad(this);
    }
  
    public int GetScore()
    {
        return score;
    }
    public void AddScore(int _score)
    {
        score += _score;
    } 
    public int GetNivel()
    {
        return nivel;
    }
    public void AddNivel()
    {
        nivel += 1;
    } 
    public void SetNivel(int _nivel)
    {
        nivel = _nivel;
    } 
    public void SetScore(int _score)
    {
        score = _score;
    } 
    public static GameManager Instance
    {
        get { return instance; }
    }
}
