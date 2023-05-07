using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EagleSpawner : MonoBehaviour
{
    [SerializeField] Eagle eagle;
    [SerializeField] Player player;
    [SerializeField] float initialTimer;
    [SerializeField] UnityEvent onEagleSpawner;

    float timer;
    void Start()
    {
        timer = initialTimer;
        eagle.gameObject.SetActive(false);
    }

    void Update()
    {
        if(timer<=0 && eagle.gameObject.activeInHierarchy == false)
        {
            eagle.gameObject.SetActive(true);
            eagle.transform.position = player.transform.position + new Vector3(0,0,13);
            player.SetMoveable(true);
            onEagleSpawner.Invoke();
            Destroy(onEagleSpawner);
        }
        
        timer -= Time.deltaTime;
    }

    private void Destroy(UnityEvent onEagleSpawner)
    {
        Destroy(gameObject);
    }

    public void ResetTimer()
    {
        timer = initialTimer;
    } 
}
