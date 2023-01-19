using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CastSpell();
    }

    void CastSpell()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Fire();
            Debug.Log("Fire");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Water();
            Debug.Log("Water");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Earth();
            Debug.Log("Earth");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Wind();
            Debug.Log("Wind");
        }
    }

    void Fire()
    {
        //display fire
    }

    void Water()
    {
        //display water
    }

    void Earth()
    {
        //display earth
    }

    void Wind()
    {
        //display wind
    }
}
