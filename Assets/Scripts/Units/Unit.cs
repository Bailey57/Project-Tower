using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Move());
        StartCoroutine(Move2());
        StartCoroutine(AttackTarget());
        
        //StartCoroutine(AttackTarget());

    }

    // Update is called once per frame
    void Update()
    {
        DeathCheck();

    }




    [SerializeField] public GameObject inGameUnit;

    [SerializeField] public GameObject attackTarget;

    [SerializeField] public Rigidbody2D rb;

    [SerializeField] public BoxCollider2D collider;

    [SerializeField] public Animator animator;

    [SerializeField] public SFXPlayer sfxPlayer;


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


    public void DeathCheck() 
    {
        if (health <= 0)
        {
            if (factionNum == 0)
            {
                GameObject deadTank = (GameObject)Instantiate(Resources.Load("Prefabs/tankUnitTst1_ded"));
                deadTank.transform.position = inGameUnit.transform.position;
            }
            else if (factionNum == 1) 
            {
                GameObject deadTank = (GameObject)Instantiate(Resources.Load("Prefabs/tankUnitTst1_enemy1_ded_"));
                deadTank.transform.position = inGameUnit.transform.position;

            }
            inGameUnit.SetActive(false);
            Destroy(inGameUnit);

        }

    }

    IEnumerator AttackTarget()
    {
        while (true) 
        {

            if (attackTarget != null)
            {
                if ((attackTarget.gameObject.GetComponent("Tower") as Tower) != null)
                {
                    (attackTarget.gameObject.GetComponent("Tower") as Tower).health -= damagePerHit;

                    Debug.Log("attackTarget: tower");
                    sfxPlayer.PlayT72Firing();
                    animator.SetInteger("State", 2);
                }
                else if ((attackTarget.gameObject.GetComponent("Unit") as Unit) != null)
                {
                    Debug.Log("attackTarget: tank");
                    (attackTarget.gameObject.GetComponent("Unit") as Unit).health -= damagePerHit;
                    sfxPlayer.PlayT72Firing();
                    animator.SetInteger("State", 2);
                }

                

            }


            yield return new WaitForSeconds(5f);
            //Debug.Log("Set State to 0");
            //animator.SetInteger("State", 0);

        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {

        //Debug.Log("Trigger entered");


        if (attackTarget == null) 
        {
            animator.SetInteger("State", 0);
            //Debug.Log("Passed 1");
            if ((other.gameObject.GetComponent("Tower") as Tower) != null)
            {
                //Debug.Log("Passed 2");
                if ((other.gameObject.GetComponent("Tower") as Tower).faction != factionNum) 
                {
                    //Debug.Log("Passed 3");
                    attackTarget = other.gameObject;

                }
               


            }

            else if ((other.gameObject.GetComponent("Unit") as Unit) != null)
            {

                
                if ((other.gameObject.GetComponent("Unit") as Unit).factionNum != factionNum)
                {
                    attackTarget = other.gameObject;

                }

            }
            
        }
        
    }


    void OnTriggerExit2D(Collider2D other)
    {
        
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


    IEnumerator Move()
    {
        
        while (true) 
        {
            Debug.Log("Move Code reached");
            //left
            //transform.position = new Vector3(-1f, 0f, 0f);

            //right
            inGameUnit.transform.position = new Vector3(inGameUnit.transform.position.x + movementSpeed / 100, 0f, 0f);
            yield return new WaitForSeconds(0.01f);//moveSpeed
        }
    }


    IEnumerator Move2()
    {

        while (true)
        {
            if (attackTarget == null)
            {
                if (factionNum == 0)
                {
                    //Debug.Log("Move Code reached");
                    //left
                    //transform.position = new Vector3(-1f, 0f, 0f);


                    //rb.MovePosition(new Vector2(inGameUnit.transform.position.x + movementSpeed * Time.deltaTime, 0f));
    
                    animator.SetInteger("State", 1);
                    rb.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, 0f);

                    //inGameUnit.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);

                    //inGameUnit.transform.position = new Vector3(inGameUnit.transform.position.x + movementSpeed / 100, 0f, 0f);


                }
                else 
                {
                    animator.SetInteger("State", 1);
                    rb.velocity = new Vector2(-1 * movementSpeed * Time.fixedDeltaTime, 0f);

                }
                

            }
            else 
            {

                rb.velocity = new Vector2(0f, 0f);
                

            }
            yield return new WaitForSeconds(1f);

        }
    }









}
