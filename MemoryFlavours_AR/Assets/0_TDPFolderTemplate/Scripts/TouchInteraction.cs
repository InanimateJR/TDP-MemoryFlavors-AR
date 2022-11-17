using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class TouchInteraction : MonoBehaviour
{
    public GameObject flour;
    public GameObject saltnSugar;
    TriggerCheck trigger;

    public Scrollbar mixingSlider;
    public GameObject mixingUI;
    int mixClickPos = 1;
    string currentTag;

    public UIManager uiManager;

    public ParticleSystem powder;
    public AudioSource mixing;

    void OnTouchPress()
    {
        
        //x n y coordinated of the touch
        Vector3 rayPosition = Touchscreen.current.primaryTouch.position.ReadValue();

        //nearclipplane is where u start seeing things
        rayPosition.z = Camera.main.nearClipPlane;

        Ray ray = Camera.main.ScreenPointToRay(rayPosition);
        RaycastHit hitInfo;

        trigger = flour.GetComponent<TriggerCheck>();
        if (Physics.Raycast(ray, out hitInfo))
        {
            if(hitInfo.collider.tag == "flour" )
            {
                flour.AddComponent<Lean.Touch.LeanDragTranslate>();
            }
            
            if (hitInfo.collider.tag == "saltnSugar" && trigger.flourEnteredBowl == true)
            {
                Debug.Log("touchedS&S");
                saltnSugar.AddComponent<Lean.Touch.LeanDragTranslate>();
            }

            
            currentTag = "mixingBtn" + mixClickPos.ToString();
            
            if(hitInfo.collider.tag == currentTag)
            {
                mixClickPos++;

                mixingSlider.size += 0.1f;
                powder.Play();
                mixing.Play();
                if (mixingSlider.size == 1)
                {
                    mixingUI.SetActive(false);
                    mixingSlider.gameObject.SetActive(false);
                    uiManager.HideStepOneOrTwo();
                    mixClickPos = 1;
                    

                }
            }
            if (mixClickPos > 4)
            {
                mixClickPos = 1;
            }
            
        }
    }
   
}
