using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Destroy()
    {
        if(keepscore.Score >= 100)
        {
            Destroy(gameObject);
        }
    }
}
