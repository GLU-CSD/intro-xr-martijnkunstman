using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsUI : MonoBehaviour
{
    public string prefabTag = "SpaceShip"; // Zorg dat je prefab deze tag heeft
    private Controls controls;


    private bool up = false;
    private bool down = false;
    private bool left = false;
    private bool right = false;

    private void action(int direction, bool pressed)
    {
        if (controls != null)
        {
            if (pressed)
            {
                if (direction == 0)
                {
                    controls.UpPressed();
                }
                else if (direction == 1)
                {
                    controls.DownPressed();
                }
                else if (direction == 2)
                {
                    controls.LeftPressed();
                }
                else if (direction == 3)
                {
                    controls.RightPressed();
                }
            }
            else
            {
                if (direction == 0)
                {
                    controls.UpReleased();
                }
                else if (direction == 1)
                {
                    controls.DownReleased();
                }
                else if (direction == 2)
                {
                    controls.LeftReleased();
                }
                else if (direction == 3)
                {
                    controls.RightReleased();
                }
            }
        }
    }

    public void UpPressed()
    {
        action(0, true);
        //Debug.Log("Up pressed - UI");
    }

    public void UpRelease()
    {
        action(0, false);
    }

    public void DownPressed()
    {
        action(1, true);
    }
    public void DownRelease()
    {
        action(1, false);
    }

    public void LeftPressed()
    {
        action(2, true);
    }
    public void LeftRelease()
    {
        action(2, false);
    }
    public void RightPressed()
    {
        action(3, true);
    }
    public void RightRelease()
    {
        action(3, false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (controls == null)
        {
            GameObject spawnedPrefab = GameObject.FindWithTag(prefabTag);
            if (spawnedPrefab != null)
            {
                controls = spawnedPrefab.GetComponent<Controls>();
            }
        }
    }
}
