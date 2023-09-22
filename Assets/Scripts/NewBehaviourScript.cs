using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed;
    void Start()
    {

    }


    void Update()
    {
        Move_Square();
        Rotate_Square();
    }
    private void Move_Square()
    {
        if (this.gameObject.transform.position.x <= 5 && this.gameObject.transform.position.y <=0)
        {
            this.gameObject.transform.position += new Vector3(5, 0, 0) * Time.deltaTime * speed;
        }
        else if (this.gameObject.transform.position.x >= 5 && this.gameObject.transform.position.y <= 5)
        {
            this.gameObject.transform.position += new Vector3(0, 5, 0) * Time.deltaTime * speed;
        }
        else if (this.gameObject.transform.position.x >=0  && this.gameObject.transform.position.y < 6 )
        {
            this.gameObject.transform.position += new Vector3(-5, 0, 0) * Time.deltaTime * speed;
            Debug.Log(this.gameObject.transform.position);
        }
        else if (this.gameObject.transform.position.x <= 0  && this.gameObject.transform.position.y >= 0)
        {
            this.gameObject.transform.position += new Vector3(0, -5, 0) * Time.deltaTime * speed;
        }


    }
    void Rotate_Square()
    {
        if (this.gameObject.transform.position.x == 5 && this.gameObject.transform.position.y == 0)
        {
            this.gameObject.transform.Rotate(0, 0, 1);
        }
        else if (this.gameObject.transform.position.x == 5 && this.gameObject.transform.position.y == 5)
        {
            this.gameObject.transform.Rotate(0, 0, 1);
        }
        else if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y == 5)
        {
            this.gameObject.transform.Rotate(0, 0, 1);
        }
        else if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y == 0)
        {
            this.gameObject.transform.Rotate(0, 0, 1);
        }
    }
}
