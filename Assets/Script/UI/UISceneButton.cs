using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UISceneButton : MonoBehaviour
{
    [SerializeField]
    private Button button;
    
    [SerializeField]
    private string scene;

    void Awake()
    {
        if(button == null)
        {
            button = GetComponent<Button>();
        }    
        button.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        if(scene == "Carga")
        {
            GameManager.Instance.AddNivel();
            SceneManager.LoadScene(scene);
      
        }
        if(scene == "Menu")
        {
            GameManager.Instance.SetNivel(0);
            GameManager.Instance.SetScore(0);
            SceneManager.LoadScene(scene);
        }
        
        SceneManager.LoadScene(scene);
        Time.timeScale = 1.0f;
    }
}
