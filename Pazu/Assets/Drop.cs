using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 6);
        Col();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Col()
    {
        switch(num)
        {
            case 0:
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 52, 51, 255);
                break;

            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(47, 154, 255, 255);
                break;

            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(34, 165, 78, 255);
                break;

            case 3:
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(252, 236, 82, 255);
                break;

            case 4:
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(165, 41, 177, 255);
                break;

            case 5:
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color32(238, 85, 171, 255);
                break;

            
           

            default:

                break;
        }
    }
}
