using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DeathCheck();


    }

    [SerializeField] public GameObject inGameTower;


    [SerializeField] public float health;

    [SerializeField] public int faction;


    public void DeathCheck()
    {
        if (health <= 0)
        {
            inGameTower.SetActive(false);
            Destroy(inGameTower);

        }

    }
}
