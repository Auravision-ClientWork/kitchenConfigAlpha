using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapInteraction : MonoBehaviour
{
    [SerializeField] Animator shelfUIAnimator;
    bool shelfUIIsOn;
    private void Start()
    {
        
        shelfUIIsOn = false;
    }
    private void OnMouseDown()
    {
        
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            ToggleShelfUI();

        }
    }

    private void ToggleShelfUI()
    {
        if(shelfUIIsOn == false)
        {
            shelfUIAnimator.SetBool("show", true);
            shelfUIIsOn = true;
        }
        else if(shelfUIIsOn == true)
        {
            shelfUIAnimator.SetBool("show", false);
            shelfUIIsOn=false;
        }
    }
}
