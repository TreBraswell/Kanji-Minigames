using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class spawning : MonoBehaviour
{
    
    public GameObject correct;
    public bool respawn = false;
    public float ranvalue = 2.0f;
    private float timer = 0.0f;
    public float waitTime = 3.0f;
    public float pos = 0.0f;
    public bool spawnwhich = false;
    public float thrust = 10.0f;

    public GameObject incorrect;
    //using public
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        pos = Random.value;

        if(pos>=.5)
        {
            ranvalue = ranvalue * -1;
        }
        if(Random.value>=.5)
        {
            spawnwhich = true;
        }
        else
        {
            spawnwhich = false;
        }
        timer += Time.deltaTime;
        Vector3 place = new Vector3(transform.position.x * ranvalue * Random.value, transform.position.y, transform.position.z);

        Sprite tex = null;
        byte[] fileData;
        
       
         
        Debug.Log("?");
        if (timer > waitTime)
        {
            timer = timer - waitTime;
            if (spawnwhich)
            {
                GameObject temp = Instantiate(incorrect, place, transform.rotation);
                temp.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.down * thrust);
                temp.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("awesome");
            }
            else
            {
                GameObject temp = Instantiate(correct, place, transform.rotation);
                temp.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.down * thrust);
                temp.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("awesome");
            }
        }

        }

      }
            
        
    

    