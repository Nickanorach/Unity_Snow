using System.Collections;

using System.Collections.Generic; using UnityEngine;

public class Bonus: MonoBehaviour
{
    public string bonusName;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.name == "Gift")
        {
            switch(bonusName)
            {

                case "coin":
                int coins = PlayerPrefs.GetInt("coins");
                PlayerPrefs.SetInt("coins", coins + 1); 
                Destroy(gameObject); 
                break;

            }
        }

    }
}