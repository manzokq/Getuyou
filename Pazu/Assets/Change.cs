using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    int x, y;

    // Start is called before the first frame update
    void Start()
    {
        x = (int)this.gameObject.transform.position.x;
        y = (int)this.gameObject.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        Debug.Log("‚¢‚¢‚¢");
    }
}
