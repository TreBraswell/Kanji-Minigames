using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteobject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
 
        if (other.name.CompareTo("correct")==0 || other.name.CompareTo("incorrect") == 0)
        {
           
        }
        else
        {
            Destroy(other.gameObject);
        }

    }

}
