using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && this.transform.position[1] < 4.25)
        {
            this.transform.position = new Vector3(this.transform.position[0], this.transform.position[1] + 0.003f, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && this.transform.position[1] > -4.25)
        {
            this.transform.position = new Vector3(this.transform.position[0], this.transform.position[1] - 0.003f, 0);
        }
    }
}
