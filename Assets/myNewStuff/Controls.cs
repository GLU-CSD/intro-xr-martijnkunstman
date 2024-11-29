using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{    
     [SerializeField] private Transform childObject;
    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;    
    void Start()
    {        
    }

    public void UpPressed()
    {
        up = true;
    }
    public void UpReleased()
    {
        up = false;
    }
    public void DownPressed()
    {
        down = true;
    }
    public void DownReleased()
    {
        down = false;
    }
    public void LeftPressed()
    {
        left = true;
    }
    public void LeftReleased()
    {
        left = false;
    }
    public void RightPressed()
    {
        right = true;
    }
    public void RightReleased()
    {
        right = false;
    }



    void Update()
    {
        if (up)
        {
            childObject.position -= new Vector3(0, 0.1f, 0);
        }
        if (down)
        {
            childObject.position += new Vector3(0, 0.1f, 0);
        }
        if (left)
        {
            childObject.position -= new Vector3(0.1f, 0, 0);
        }
        if (right)
        {
            childObject.position += new Vector3(0.1f, 0, 0);
        }
    }
}
