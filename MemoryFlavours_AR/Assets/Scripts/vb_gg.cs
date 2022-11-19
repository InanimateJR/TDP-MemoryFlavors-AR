using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class vb_gg : MonoBehaviour
{

    public GameObject vbBtnGG;
    public Animator ggAnim;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnGG = GameObject.Find("ggBtn");
        vbBtnGG.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnGG.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        ggAnim.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ggAnim.Play("ggAnim");
        Debug.Log("Button Pressed");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        ggAnim.Play("none");
        Debug.Log("Button Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
