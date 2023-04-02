using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentUnits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*


    [SerializeField] public Unit unit;
    public Text healthText;
    public Text damageText;
    public Text speedText;

    public int healthUpgradeCost = 10;
    public int damageUpgradeCost = 10;
    public int speedUpgradeCost = 10;
    public int rangeUpgradeCost = 10;
    public int healthUpgradeAmount = 10;
    public int damageUpgradeAmount = 5;
    public float speedUpgradeAmount = 0.5f;
    public int rangeUpgradeAmount = 3;


    class Healer : Unit
    {
        //   Name ="Healer";
        //Health = 20;
        //Damage = -2;
        //Speed = 10f;
        //   Range = 20;

    }
    class Melee : Unit
    {
        //Name = "Melee";
        //Health = 30;
        //Damage = 10;
        //Speed = 20f;
        //Range = 10;
    }
    class Tank : Unit
    {
        //Name = "Tank";
        //Health = 50;
        //Damage = 15;
        //Speed = 10f;
        //Range = 8;
    }
    class Distance : Unit
    {
        //Name = "Distance"
        //Health = 20;
        //Damage = 15;
        //Speed = 15f;
        //Range = 25;
    }
    public void UpgradeHealth2()
    {
        unit.health += healthUpgradeAmount;
    }

    public void UpgradeDamage2()
    {
        unit.damage += damageUpgradeAmount;
    }

    public void UpgradeSpeed2()
    {
        unit.speed += speedUpgradeAmount;
    }

    public void UpgradeRange2()
    {
        unit.range += rangeUpgradeAmount;
    }




    public void UpgradeHealth()
    {
        if (GameManager.instance.gold >= unit.healthUpgradeCost)
        {
            GameManager.instance.gold -= unit.healthUpgradeCost;
            unit.UpgradeHealth2();
            UpdateStats();
        }
    }

    public void UpgradeDamage()
    {
        if (GameManager.instance.gold >= unit.damageUpgradeCost)
        {
            GameManager.instance.gold -= unit.damageUpgradeCost;
            unit.UpgradeDamage2();
            UpdateStats();
        }
    }

    public void UpgradeSpeed()
    {
        if (GameManager.instance.gold >= unit.speedUpgradeCost)
        {
            GameManager.instance.gold -= unit.speedUpgradeCost;
            unit.UpgradeSpeed2();
            UpdateStats();
        }
    }

    public void UpgradeRange()
    {
        if (GameManager.instance.gold >= unit.rangeUpgradeCost)
        {
            GameManager.instance.gold -= unit.rangeUpgradeCost;
            unit.UpgradeRange2();
            UpdateStats();
        }
    }

    private void UpdateStats()
    {
        healthText.text = "Health: " + unit.health.ToString();
        damageText.text = "Damage: " + unit.damage.ToString();
        speedText.text = "Speed: " + unit.speed.ToString();
        rangeText.text = "Speed: " + unit.speed.ToString();
    }




    */

}
