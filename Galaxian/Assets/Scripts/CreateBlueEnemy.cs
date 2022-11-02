using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlueEnemy : MonoBehaviour
{
    int ENEMY_WIDTH = 10;
    int ENEMY_HEIGHT = 3;
    public List<GameObject> blue_enemies = new List<GameObject>();
    public GameObject blue_enemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ENEMY_WIDTH; i++)
        {
            for (int j = 0; j < ENEMY_HEIGHT; j++)
            {
                blue_enemies.Add(Instantiate(blue_enemy, new Vector3(i * 0.6f - 2.7f, j*0.6f+2.6f, 0), Quaternion.identity));

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
