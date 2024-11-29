using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpDown : MonoBehaviour
{
    //public float maxHeight = 100f;
    //public float currentHeight;
    [SerializeField] private Transform childObject;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.position += new Vector3(0, 0.1f, 0);
    }

    public void GoDown(float amount)
    {
        //currentHeight -= amount;
        //currentHeight = Mathf.Clamp(currentHeight, 0, maxHeight);
        childObject.position -= new Vector3(0, 0.1f, 0);
    }

    public void GoUp(float amount)
    {
        //currentHeight += amount;
        //currentHeight = Mathf.Clamp(currentHeight, 0, maxHeight);
        childObject.position += new Vector3(0, 0.1f, 0);
    }
}
