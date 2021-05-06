using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ColliderClick : MonoBehaviour
{
public string nextScene;
    public Text txt;
    //TIMER
    private bool isLooked = false;

    public GameObject gameObject;
    public float timerDuration = 3f;

    private float lookTimer = 0f;

    void Start()
    {
    }

    void Update()
    {
        if (isLooked)
        {
            lookTimer += Time.deltaTime;

            if (lookTimer > timerDuration)
            {
                lookTimer = 0f;
                OnPointerClick();
            }
        }
        else
        {
            lookTimer = 0f;
        }
    }

    public void setIsLooked(bool looked)
    {
        isLooked = looked;
    }

    public void OnPointerClick()
    {
 
SceneManager.LoadScene(nextScene);
    }

}
