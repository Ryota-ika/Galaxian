using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRedEnemy : MonoBehaviour {
    const int ENEMY_WIDTH = 6;
    public List<GameObject> red_enemies = new List<GameObject>();
    public GameObject red_enemy;
    // Start is called before the first frame update
    void Start( ) {
        for( int i = 0; i < ENEMY_WIDTH; i++ ) {
            red_enemies.Add( Instantiate( red_enemy, new Vector3( i * 0.6f-1.5f, 5, 0 ), Quaternion.identity ));
        }
    }

    // Update is called once per frame
    void Update( ) {

    }
}
