using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierTMP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //displays height of soldier. He is a little over 6 feet tall.
        Debug.Log(GetComponent<SkinnedMeshRenderer>().bounds.size.y); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
