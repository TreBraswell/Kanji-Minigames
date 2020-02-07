using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject leftbound;
    public GameObject rightbound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = new Vector3(Input.mousePosition.x, transform.position.y,transform.position.z);
        //transform.Translate(pos);
        if (Input.mousePosition.x > rightbound.transform.position.x || Input.mousePosition.x <leftbound.transform.position.x)
        {

        }
        else
        {
            transform.position = pos;
        }
        
        /*Vector3 wantedPos = Camera.main.ScreenToWorldPoint(pos);

        transform.position = wantedPos;*/
    }
}
