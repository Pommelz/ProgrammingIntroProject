using System.Collections.Generic;
using UnityEngine;

public class LoopExample : MonoBehaviour
{
    [SerializeField] int spriteAmount = 3;
    [SerializeField] float distance = 1f;
    [SerializeField] GameObject spritePrefab;
    [SerializeField] Transform spawnPositionReference;

    List<GameObject> spawnedSpritesList = new List<GameObject>();

    public void SpawnSprites()
    {
        for (int i = 0; i < spriteAmount; i++)
        {
            // SpawnPosition at start position + (1,0,0) * Distance * Index
            Vector3 spawnPosition = spawnPositionReference.position + Vector3.right * distance * i;

            // Spawn object
            GameObject spawnedSprite = GameObject.Instantiate(spritePrefab, spawnPosition, Quaternion.identity);

            // Add spawned object to List
            spawnedSpritesList.Add(spawnedSprite);
        }
    }

    public void DestroySprites()
    {
        // As the list is empty we don't need to destroy anything
        if (spawnedSpritesList.Count == 0)
            return;

        // Foreach spawned object in list
        foreach(GameObject spawnedSprite in spawnedSpritesList)
        {
            // Destroy object
            Destroy(spawnedSprite);
        }
    }
}
