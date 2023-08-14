using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    [SerializeField] private GameObject block;

    public void SetBlock(bool bl)
    {
        block.SetActive(bl); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
