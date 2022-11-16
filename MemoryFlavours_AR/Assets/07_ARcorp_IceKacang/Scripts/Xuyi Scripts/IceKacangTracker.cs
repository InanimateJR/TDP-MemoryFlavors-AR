using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceKacangTracker : MonoBehaviour
{
    public TouchHandler touchHandle;
    public GameObject iceKacang;
    public GameObject resetBtn;
    public GameObject[] chendol;
    public GameObject[] grassJelly;
    public GameObject[] seed;
    public GameObject[] corn;
    public GameObject[] redBean;
    public GameObject[] redSyrup;
    public GameObject[] blueSyrup;
    public GameObject[] greenSyrup;
    public GameObject sugar;
    public GameObject milk;
    public bool isChendol;
    public bool isJelly;
    public bool isSeed;
    public bool isCorn;
    public bool isBean;
    public bool isRedS;
    public bool isBlueS;
    public bool isGreenS;
    public Animator iceAnim;
    public Animator ingreAnim;
    public ParticleSystem snow;
    private int toppingNo;
    private int syrupNo;
    // Start is called before the first frame update
    void Start()
    {
        toppingNo = 0;
        syrupNo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowFood()
    {
        iceAnim.SetBool("isIce", true);
        snow.Play();

    }
    public void HideFood()
    {
        iceAnim.SetBool("isIce", false);
        touchHandle.ingredients.SetBool("isIngre", false);
        resetBtn.SetActive(false);
        ToppingsReset();

    }
    public void Toppings()
    {
        if (toppingNo == 0 && toppingNo<=2)
        {
            if (isChendol == true)
            {
                chendol[0].SetActive(true);
            }
            else if(isJelly == true)
            {
                grassJelly[0].SetActive(true);
            }
            else if (isSeed == true)
            {
                seed[0].SetActive(true);
            }
            else if (isCorn == true)
            {
                corn[0].SetActive(true);
            }
            else if (isBean == true)
            {
                redBean[0].SetActive(true);
            }
        }
        else if (toppingNo == 1 && toppingNo <= 2)
        {
            if (isChendol == true)
            {
                chendol[1].SetActive(true);
            }
            else if (isJelly == true)
            {
                grassJelly[1].SetActive(true);
            }
            else if (isSeed == true)
            {
                seed[1].SetActive(true);
            }
            else if (isCorn == true)
            {
                corn[1].SetActive(true);
            }
            else if (isBean == true)
            {
                redBean[1].SetActive(true);
            }
        }
        else if (toppingNo == 2 && toppingNo <= 2)
        {
            if (isChendol == true)
            {
                chendol[2].SetActive(true);
            }
            else if (isJelly == true)
            {
                grassJelly[2].SetActive(true);
            }
            else if (isSeed == true)
            {
                seed[2].SetActive(true);
            }
            else if (isCorn == true)
            {
                corn[2].SetActive(true);
            }
            else if (isBean == true)
            {
                redBean[2].SetActive(true);
            }
        }
        toppingNo++;
        isChendol = false;
        isJelly = false;
        isSeed = false;
        isCorn = false;
        isBean = false;
    }

    public void Syrups()
    {
        if(syrupNo==0 && syrupNo <= 1)
        {
            if (isRedS == true)
            {
                redSyrup[0].SetActive(true);
            }
            else if (isBlueS == true)
            {
                blueSyrup[0].SetActive(true);
            }
            else if (isGreenS == true)
            {
                greenSyrup[0].SetActive(true);
            }
        }
        else if (syrupNo == 1 && syrupNo <= 1)
        {
            if (isRedS == true)
            {
                redSyrup[1].SetActive(true);
            }
            else if (isBlueS == true)
            {
                blueSyrup[1].SetActive(true);
            }
            else if (isGreenS == true)
            {
                greenSyrup[1].SetActive(true);
            }
        }
        syrupNo++;
        isRedS = false;
        isBlueS = false;
        isGreenS = false;
    }
    public void Sugar()
    {
        sugar.SetActive(true);
    }
    public void Milk()
    {
        milk.SetActive(true);
    }
    public void ToppingsReset()
    {
        toppingNo = 0;
        syrupNo = 0;
        sugar.SetActive(false);
        milk.SetActive(false);
        for(int i = 0; i <= 2; i++)
        {
            chendol[i].SetActive(false);
            grassJelly[i].SetActive(false);
            seed[i].SetActive(false);
            redBean[i].SetActive(false);
            corn[i].SetActive(false);
        }
        for (int i = 0; i <= 1; i++)
        {
            redSyrup[i].SetActive(false);
            blueSyrup[i].SetActive(false);
            greenSyrup[i].SetActive(false);
        }
    }
}
