using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    private PetaniAttack petani;
    private EnemyAttack enemy;

    void Start()
    {
        petani = GameObject.FindGameObjectWithTag("Player").GetComponent<PetaniAttack>();
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyAttack>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            enemy.enemyPoint += 10;
        }

        if(collision.gameObject.tag == "Enemy")
        {
            petani.playerPoint += 10;
        }

        Destroy(gameObject);

    }

}
