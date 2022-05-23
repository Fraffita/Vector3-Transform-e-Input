using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenScript : MonoBehaviour
{
    public GameObject egg;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(egg);
            clon.transform.position = transform.position;
        }


    }
}
