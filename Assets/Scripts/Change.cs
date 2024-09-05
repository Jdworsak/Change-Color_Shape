using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public Mesh[] shapes;
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;              //
    private int shapeIndex = 0;

    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();
        if (shapes.Length > 0) meshFilter.mesh = shapes[shapeIndex];        //
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shapeIndex = (shapeIndex + 1) % shapes.Length;
            meshFilter.mesh = shapes[shapeIndex];       //Goes through thr filter to see how many shapes 
            meshRenderer.material.color = new Color(Random.value, Random.value, Random.value);      //Randomly tell you 
        }
    }
}


//Cite by ChatGPT https://chatgpt.com/