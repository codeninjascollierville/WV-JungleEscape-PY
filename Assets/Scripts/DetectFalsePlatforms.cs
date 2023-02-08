using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;
    int FalseLayer = 1 << 8;
    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.forward, 2f, FalseLayer);
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);
        if(hit)
        {
            Debug.LogWarning("Watch out!!");
        }else{
            Debug.Log("All Good");
        }
    }   
}
