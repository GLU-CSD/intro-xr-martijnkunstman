using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            if (direction == 0)
            {
                controls.UpPressed;
            }
            else if (direction == 1)
            {
                controls.down = pressed;
            }
            else if (direction == 2)
            {
                controls.left = pressed;
            }
            else if (direction == 3)
            {
                controls.right = pressed;
            }
        }
    }

    public void UpPressed()
    {
        action(0, true);
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
