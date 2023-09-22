using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tam_giac : MonoBehaviour
{

    void Update()
    {
        tam_giac_can();
    }
    void tam_giac_can()
    {
        if(this.gameObject.transform.position.x == 0 && this.transform.position.y == 0)
        {
            this.gameObject.transform.position += new Vector3(6, 0, 0);
        }
        else if (this.gameObject.transform.position.x == 6 && this.transform.position.y == 0)
        {
            this.gameObject.transform.position += new Vector3(-6, 6, 0);
        }
    }
}
