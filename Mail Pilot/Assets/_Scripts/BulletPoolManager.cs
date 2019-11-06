using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;
    public int noOfBullets;
    public PlayerController playerController;

    //TODO: create a structure to contain a collection of bullets
    List<GameObject> bullets = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
        for (int i = 0; i <= 10; i++)
        {
            bullets.Add(Instantiate(bullet));
            bullets[i].gameObject.SetActive(false);
        }
        noOfBullets = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (noOfBullets > 10)
        {
            noOfBullets = 0;
        }
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        noOfBullets++;
        bullets[noOfBullets-1].gameObject.SetActive(true);
        return bullets[noOfBullets-1];
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        bullet.SetActive(false);
    }
}
