using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject Enemy;
    private int timer;
    public int FramesPerSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > FramesPerSpawn)
        {
            Instantiate(Enemy);
            timer = 0;
        }
        timer++;
    }
}
