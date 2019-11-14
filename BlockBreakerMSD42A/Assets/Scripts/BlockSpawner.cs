﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    Vector2 blockPosition, startingBlockPosition;

    GameObject randomBlock;

    GameObject[] blockArray;

    // Start is called before the first frame update
    void Start()
    {
        blockArray = Resources.LoadAll<GameObject>("Blocks");
        //set the starting point to the position of the Empty object
        startingBlockPosition = transform.position;
        blockPosition = startingBlockPosition;

        PrintBlocksOnXAndY();
        
    }

    private void GetAndSpawnRandomBlock()
    {
        int randomNumber = Random.Range(0, blockArray.Length);
        randomBlock = blockArray[randomNumber];

        Instantiate(randomBlock, blockPosition, transform.rotation);
    }

    private void PrintBlocksOnXAndY()
    {
        for (int y = 5; y > 1; y--)
        {
            for (int x = 1; x < 15; x += 2)
            {
                GetAndSpawnRandomBlock();
                blockPosition.x += 2;

            }

            blockPosition.x = startingBlockPosition.x;
            blockPosition.y -= 2;

        }
    }

    
}
