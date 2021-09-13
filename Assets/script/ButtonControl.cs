using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GameObject dragon;
    private int dragon_state;
    // Start is called before the first frame update
    void Start()
    {
        dragon_state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btn_attack()
    {
        if (dragon_state == 0)
        {
            dragon.GetComponent<Animator>().Play("attack");
        }
        else
        {
            dragon.GetComponent<Animator>().Play("big_attack");
        }
    }

    public void btn_ice()
    {
        if (dragon_state == 0)
        {
            dragon.GetComponent<Animator>().Play("ice");
        }
        else
        {
            dragon.GetComponent<Animator>().Play("big_ice");
        }
    }

    public void btn_grow()
    {
        dragon.GetComponent<Animator>().Play("grow");
        dragon_state = 1;
    }
}
