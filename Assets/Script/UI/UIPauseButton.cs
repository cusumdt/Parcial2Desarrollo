using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIPauseButton : MonoBehaviour
{
    [SerializeField]
    private Button button;
    [SerializeField]
    private GameObject panel;
    private bool pause = false;
    [SerializeField]
    private Sprite pauseImage;
    [SerializeField]
    private Sprite playImage;
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
        if(!pause)
        {
            pause=!pause;;
            button.image.sprite = playImage;
            panel.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else
        {
            pause=!pause;
            button.image.sprite = pauseImage;
            panel.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
}
