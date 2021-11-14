using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && this.transform.position[1] < 4.25)
        {
            this.transform.position = new Vector3(this.transform.position[0], this.transform.position[1] + 0.003f, 0);
        }else if (Input.GetKey(KeyCode.S) && this.transform.position[1] > -4.25)
        {
            this.transform.position = new Vector3(this.transform.position[0], this.transform.position[1] - 0.003f, 0);
        }
    }
}
