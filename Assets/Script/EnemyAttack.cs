using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAttack : MonoBehaviour
{
    public int damage;
    public float bulletForce;

    public Transform bulletSpawn;
    public GameObject bullet;

    private bool hasShot = false;

    public int enemyPoint = 0;

    public Text enemyPointText;

    void Start()
    {
        StartCoroutine(DelayShot());
    }

    void Update()
    {
        enemyPointText.text = enemyPoint.ToString();
    }

    void EnemyShoot()
    {
            GameObject bulletRef = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);//ngluarkan peluru
            Rigidbody2D rbBullet = bulletRef.GetComponent<Rigidbody2D>();

            rbBullet.AddForce(-bulletSpawn.right * bulletForce, ForceMode2D.Impulse);

            hasShot = true;
    }

    IEnumerator DelayShot()
    {
        while (!hasShot)
        {
            EnemyShoot();

            yield return new WaitForSeconds(3);

            hasShot = false;
        }
    }
}