using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class PetaniAttack : MonoBehaviour
{
    public int damage;
    public float bulletForce;

    public Transform bulletSpawn;
    public GameObject bullet;

    private bool hasShot = false;

    public int playerPoint = 0;

    public Text pointPetaniText;

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }*/

        pointPetaniText.text = playerPoint.ToString();
    }

    public void Shoot()
    {
        if (!hasShot)
        {
            GameObject bulletRef = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);//ngluarkan peluru
            Rigidbody2D rbBullet = bulletRef.GetComponent<Rigidbody2D>();
            
            rbBullet.AddForce(bulletSpawn.right * bulletForce, ForceMode2D.Impulse);

            hasShot = true;

            StartCoroutine(DelayShot());
        }

    }

    IEnumerator DelayShot()
    {
        yield return new WaitForSeconds(1);

        hasShot = false;
    }
}
