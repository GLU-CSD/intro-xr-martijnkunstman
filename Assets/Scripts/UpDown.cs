using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpDown : MonoBehaviour
{
    public float maxHeight = 100f;
    public float currentHeight;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3(0, currentHeight, 0);
    }

    public void GoDown(float amount)
    {
        currentHeight -= amount;
        currentHeight = Mathf.Clamp(currentHeight, 0, maxHeight);
    }

    public void GoUp(float amount)
    {
        currentHeight += amount;
        currentHeight = Mathf.Clamp(currentHeight, 0, maxHeight);
    }
}
