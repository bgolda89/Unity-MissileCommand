﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class GameController : MonoBehaviour
{
    //public GameObject hazard;
    //public Vector3 spawnValues;
    //public int hazardCount;
    //public float spawnWait;
    //public float startWait;
    //public float waveWait;

    //public TextMeshPro restartText;
    //public TextMeshPro gameOverText;

    private bool gameOver;
    private bool restart;
    private int score;

    SceneManager sceneManager;


    void Start()
    {
        gameOver = false;
        restart = false;
        //restartText.text = "";
        //gameOverText.text = "";
        score = 0;
        //UpdateScore();
        //StartCoroutine(SpawnWaves());
    }

    void Update()
    {
        //if (restart)
        //{
        //    if (Input.GetKeyDown(KeyCode.R))
        //    {
        //        SceneManager.LoadScene(0);
        //    }
        //}
    }

    //IEnumerator SpawnWaves()
    //{
    //    yield return new WaitForSeconds(startWait);
    //    while (true)
    //    {
    //        for (int i = 0; i < hazardCount; i++)
    //        {
    //            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
    //            Quaternion spawnRotation = Quaternion.identity;
    //            Instantiate(hazard, spawnPosition, spawnRotation);
    //            yield return new WaitForSeconds(spawnWait);
    //        }
    //        yield return new WaitForSeconds(waveWait);

    //        if (gameOver)
    //        {
    //            //restartText.text = "Press 'R' for Restart";
    //            restart = true;
    //            break;
    //        }
    //    }
    //}
}