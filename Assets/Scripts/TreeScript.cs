using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public int Health = 100;
    
    private void OnCollisionEnter(Collision other)
    {
        Health = Health - 10;
        Debug.Log("it works");
        if (Health <= 0)
        {
           transform.gameObject.SetActive(false);
        }
    }
        
    
}
