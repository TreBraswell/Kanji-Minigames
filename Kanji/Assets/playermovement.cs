using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    private Vector3 mouse;
    public Rigidbody player;
    public Vector3 start;
    public float speed = 1.0F;
    private float startTime;
    private float Length;
    // Start is called before the first frame update
    void Start()
    {
        start = this.gameObject.transform.position;
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Mouse X");
        mouse = Input.mousePosition;
        

    }
}
