using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bann : MonoBehaviour
{

    public GameObject drop;
    GameObject[,] B = new GameObject[6, 5];

    // Start is called before the first frame update
    void Start()
    {
        Jen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Jen()
    {
        for(int i=0;i<B.GetLength(1);i++)
        {
            for (int j = 0; j < B.GetLength(0); j++)
            {
                Instantiate(drop, new Vector3(j, i, 1), Quaternion.identity);
            }
        }
            
    }


}
