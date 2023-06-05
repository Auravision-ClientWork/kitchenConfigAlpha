using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMatPanel : MonoBehaviour
{
    bool matPanelIsShowing;
    [SerializeField] Animator matPanelAnimator;

    public void SetShowMatPanel()
    {
        FindObjectOfType<AudioManager>().PlayButtonFx();
        if(matPanelIsShowing == false)
        {
            matPanelAnimator.SetBool("show", true);
            matPanelIsShowing = true;
        }
        else if(matPanelIsShowing == true)
        {
            matPanelAnimator.SetBool("show", false); 
            matPanelIsShowing = false;
        }
    }
}
