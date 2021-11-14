using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Text p1;
    public Text p2;

    public float y_speed = 0.003f;
    public float x_speed = 0.003f;
    private int p1_score = 0;
    private int p2_score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        p2.text = "Score " + p2_score;
        p1.text = "Score " + p1_score;


        if (this.transform.position[1] >= 4.751){
            y_speed = -y_speed;
        }
        else if(this.transform.position[1] <= -4.751)
        {
            y_speed = Math.Abs(y_speed);
        }

        if (this.transform.position[0] >= 10.692)
        {
            this.transform.position = new Vector3(0, 0.028f, 0);
            x_speed = -x_speed;
            p1_score++;
        }
        else if(this.transform.position[0] <= -10.692)
        {
            this.transform.position = new Vector3(0, 0.028f, 0);
            x_speed = Math.Abs(x_speed);
            p2_score++;
        }

        collistion();

        this.transform.position = new Vector3(this.transform.position[0] + x_speed, this.transform.position[1] + y_speed, 0);
    }


    void collistion()
    {
        Vector3 p2_pos = GameObject.FindWithTag("p2").transform.position;
        Vector3 p1_pos = GameObject.FindWithTag("p1").transform.position;

        if (this.transform.position[0] >= 9.604 && this.transform.position[0] <= 9.9)
        {
            if ((this.transform.position[1] - 1) < p2_pos[1] && (this.transform.position[1] + 1) > p2_pos[1])
            {
                x_speed = -x_speed;
            }
        }

        if (this.transform.position[0] <= -9.604 && this.transform.position[0] > -10)
        {
            if ((this.transform.position[1] - 1) < p2_pos[1] && (this.transform.position[1] + 1) > p2_pos[1])
            {
                x_speed = Math.Abs(x_speed);
            }
        }
    }
}
