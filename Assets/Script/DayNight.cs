using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public Skybox skybox;

    int skynumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1.4f);
    }



    public void ChangeSkybox(int skynumber)
    {
        switch (skynumber)
        {
            case 1:
                Debug.Log("Sky Box---1");
                RenderSettings.skybox = skybox.Materials[0];

                break;
            case 2:
                RenderSettings.skybox = skybox.Materials[1];
                Debug.Log("Sky Box---2");
                break;
            case 3:
                RenderSettings.skybox = skybox.Materials[2];
                Debug.Log("Sky Box---3");
                break;
            case 4:
                RenderSettings.skybox = skybox.Materials[3];
                Debug.Log("Sky Box---4");
                break;

        }
    }
}


