using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemyCtlr : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerGun")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            Destroy(this.gameObject);
            //instantiate‚ğg‚¢‚·‚¬‚é‚Æˆ—‚ª‚¨‚à‚­‚È‚é‚Ì‚Åpooling‚É•ÏX
            //Instantiate(explosion,transform.position,Quaternion.identity);
        }
    }
}
