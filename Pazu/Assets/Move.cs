using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    int x, y;
    int num, numx, numy;
   
    bool f;
    // Start is called before the first frame update
    void Start()
    {

        //Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = new Vector3(x, y, 1);
    }

    void Pos()
    {

    }

    private void OnMouseDown()
    {
        x = (int)this.gameObject.transform.position.x;
        y = (int)this.gameObject.transform.position.y;

    }

    private void OnMouseDrag()
    {
        this.transform.position =  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));

    }

    private void OnMouseUp()
    {
        num = Mathf.FloorToInt(this.transform.position.x);
        if (this.transform.position.x - num <= 0.4)
        {
            numx = num;
        }
        else if (this.transform.position.x - num > 0.5)
        {
            numx = num + 1;
        }
        num = Mathf.FloorToInt(this.transform.position.y);
        if (this.transform.position.y - num <= 0.4)
        {
            numy = num;
        }
        else if (this.transform.position.y - num > 0.5)
        {
            numy = num + 1;
        }



        this.transform.position = new Vector3(numx, numy, 1);
    }

}
