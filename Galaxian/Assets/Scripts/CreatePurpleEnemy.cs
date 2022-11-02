using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePurpleEnemy : MonoBehaviour
{
    int ENEMY_WIDTH=8;
    public List<GameObject> purple_enemies = new List<GameObject>();
    public GameObject purple_enemy;
    // Start is called before the first frame update
    void Start()
    {
        for( int i = 0; i < ENEMY_WIDTH; i++ ) {
            purple_enemies.Add(Instantiate(purple_enemy,new Vector3( i * 0.6f - 2.1f, 4.4f, 0 ),Quaternion.identity ));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
