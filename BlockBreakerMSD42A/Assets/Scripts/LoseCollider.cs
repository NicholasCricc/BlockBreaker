﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] SceneLoader sceneLoader;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        sceneLoader.LoadLevel("GameOver");
    }
}
