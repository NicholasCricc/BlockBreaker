using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    SceneLoader sceneLoader;

    [SerializeField] int breakableBlocks;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    //this method will be called everytime a block is destroyed
    public void BlockDestroyed()
    {
        breakableBlocks--;

        if(breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }



    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

}
