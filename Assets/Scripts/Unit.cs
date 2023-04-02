using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    [SerializeField] public GameObject gameObject;

    [SerializeField] public GameObject attackTarget;



    [SerializeField] public float health;
    [SerializeField] public float maxHealth;
    //[SerializeField] float armor; //might add when everything else is dine 

    [SerializeField] public float damagePerHit;
    [SerializeField] public float movementSpeed;
    [SerializeField] public float attackSpeed;
    [SerializeField] public float attackRange;

    //faction 1 = player
    //faction 2 = enemy
    [SerializeField] public int factionNum; 


    public Unit(float health, float maxHealth, float damagePerHit, float movementSpeed, float attackSpeed, float attackRange, int factionNum) 
    {
        this.health = health;   
        this.maxHealth = maxHealth;
        this.damagePerHit = damagePerHit;
        this.movementSpeed = movementSpeed;
        this.attackSpeed = attackSpeed;
        this.attackRange = attackRange;
        this.factionNum = factionNum;
    
    }

    public void GetTarget()
    {
        if (attackTarget)
        {

        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {

        //Debug.Log("Trigger entered");

        if (attackTarget == null) 
        {
            attackTarget = other.gameObject;
        }
        
    }


    void OnTriggerExit2D(Collider2D other)
    {
        
    }


    //IEnumerator
    public void AttackTarget()
    {
        //take away the targets health

    }

    public float GetDistanceToTarget()
    {
        if (this.attackTarget == null)
        {
            return -1;
        }
        return Vector2.Distance(transform.position, attackTarget.transform.position);
    }


    public bool TargetInRange()
    {
        float scale = 25;
        //Debug.Log("Distance: " + GetDistance() * scale);
        if (this.attackTarget == null)
        {
            return false;
        }
        if (GetDistanceToTarget() * scale < this.attackRange)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public void Move()
    {
        //left
        transform.position = new Vector3(-1f, 0f, 0f);

        //right
        transform.position = new Vector3(1f, 0f, 0f);


    }


    






}
