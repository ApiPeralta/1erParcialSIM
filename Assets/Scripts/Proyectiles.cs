using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proyectiles : MonoBehaviour
{
    public GameObject proyectil;
    public GameObject[] instantiatePos;
    public float respawningTimer;

    void Update()
    {
        SpawnEnemies();
    }
    private void SpawnEnemies()
    {
        respawningTimer -= Time.deltaTime;
        if (respawningTimer <= 0)
        {
            Instantiate(proyectil, instantiatePos[UnityEngine.Random.Range(0,4)].transform);
            respawningTimer = UnityEngine.Random.Range(3, 5);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("jugador"))
        {
            Debug.Log("Hola");
            SceneManager.LoadScene(0);
        }
    }
}