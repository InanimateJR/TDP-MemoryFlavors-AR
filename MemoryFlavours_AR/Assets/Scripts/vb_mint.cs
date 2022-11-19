using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_mint : MonoBehaviour
{
    public GameObject vbBtnMint;
    public Animator mintAnim;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnMint = GameObject.Find("mintBtn");
        vbBtnMint.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnMint.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        mintAnim.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        mintAnim.Play("mintAnim");
        Debug.Log("Button Pressed");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        mintAnim.Play("none");
        Debug.Log("Button Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
