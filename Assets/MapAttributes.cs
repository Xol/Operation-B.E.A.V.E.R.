using System.Collections.Generic;
using UnityEngine;

public class MapAttributes : MonoBehaviour
{
    public Transform bush;
    public Transform wolf;
    private List<Transform> bushs = new List<Transform>();
    private List<Transform> wolfs = new List<Transform>();
    private int[] bushPrefabPositions = { -13, 0, 15 };

    private const int WAIT_FOR_ENEMY = 60;
    public int waitForEnemy = WAIT_FOR_ENEMY;

    private void Start()
    {
        for (int i = 0; i < bushPrefabPositions.Length; i++)
        {
            bushs.Add(spawnPrefab(bushPrefabPositions[i], bush));
        }
    }

    void FixedUpdate()
    {
        waitForEnemy -= 1;

        if (waitForEnemy == 0)
        {
            if(wolfs.Count > 0)
            {
                Destroy(wolfs[0].gameObject);
                wolfs.RemoveAt(0);
            }

            wolfs.Add(spawnPrefab(bushPrefabPositions[getRandomArrayPos(bushPrefabPositions.Length)], wolf));
            waitForEnemy = WAIT_FOR_ENEMY;

        }
    }

    private int getRandomArrayPos(int length)
    {
        System.Random generator = new System.Random();
        int randomArrayPos = generator.Next(0, length);

        return randomArrayPos;
    }

    private Transform spawnPrefab(int posX, Transform tType)
    {
        return Instantiate(tType, new Vector2(posX, -1.8f), Quaternion.identity);
    }
}
