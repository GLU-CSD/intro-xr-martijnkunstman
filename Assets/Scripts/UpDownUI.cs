using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownUI : MonoBehaviour
{
    public string prefabTag = "Boid"; // Zorg dat je prefab deze tag heeft
    private UpDown updDownScript;

    public void UpButton()
    {
        if (updDownScript != null)
        {
            updDownScript.GoUp(0.1f);
        }
    }

    public void DownButton()
    {
        if (updDownScript != null)
        {
            updDownScript.GoDown(0.1f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (updDownScript == null)
        {
            GameObject spawnedPrefab = GameObject.FindWithTag(prefabTag);
            if (spawnedPrefab != null)
            {
                updDownScript = spawnedPrefab.GetComponent<UpDown>();
            }
        }
    }
}
