using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] Text coinsText;
    [SerializeField] AudioSource collectionSound;
    [SerializeField] GameObject particleEffectPrefab; // Reference to the particle effect prefab
    [SerializeField] GameObject particleEffectPrefabFinish;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
            collectionSound.Play();

            // Instantiate particle effect at the position of the collected coin
            if (particleEffectPrefab != null)
            {
                Instantiate(particleEffectPrefab, other.transform.position, Quaternion.identity);
            }
        }

         if (other.gameObject.CompareTag("Finish"))
        {
            
             Destroy(other.gameObject);

            // Instantiate particle effect at the position of the collected coin
            if (particleEffectPrefabFinish != null)
            {
                Instantiate(particleEffectPrefabFinish, other.transform.position, Quaternion.identity);
            }
        }
    }
}
