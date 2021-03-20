using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerImageBehaviour : MonoBehaviour
{
    public GameObject ParentObject;

    private void Start()
    {
        
    }

    private void OnDisable()
    {
        this.ParentObject.SetActive(false);
    }
}
