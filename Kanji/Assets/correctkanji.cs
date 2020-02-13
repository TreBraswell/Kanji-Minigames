using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class correctkanji : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("this is a correct kanji");
        if (col.tag== "correct")
        {
            Debug.Log("this is a correct kanji");
            Destroy(col.gameObject);
        }
        else if(col.tag == "incorrect")
        {
            Debug.Log("this is an incorrect kanji");
            Destroy(col.gameObject);
        }
    }
}
