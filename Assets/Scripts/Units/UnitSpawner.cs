using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{

    [SerializeField] public GameObject tower;



    // Start is called before the first frame update
    void Start()
    {

        if ((tower.gameObject.GetComponent("Tower") as Tower).faction == 0)
        {
            //SpawnOneFriendlyUnit();


        }
        else 
        {
            StartCoroutine(SpawnOneEnemyUnit());
         



        }        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    




    public void SpawnOneFriendlyUnit()
    {




        GameObject newObject = (GameObject)Instantiate(Resources.Load("Prefabs/tankUnitTst1_idle"));
        newObject.transform.position = new Vector3(tower.transform.position.x + 1, tower.transform.position.y, tower.transform.position.z);
        




    }


    IEnumerator SpawnOneEnemyUnit()
    {
        while (true)
        {



            GameObject newObject = (GameObject)Instantiate(Resources.Load("Prefabs/tankUnitTst1_idle_enemy1"));
            newObject.transform.position = new Vector3(tower.transform.position.x - 1, tower.transform.position.y, tower.transform.position.z);


            yield return new WaitForSeconds(10);
        }

    }






}
