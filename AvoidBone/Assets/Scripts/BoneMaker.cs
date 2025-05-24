using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BoneMaker : MonoBehaviour
{
    public GameObject[] bonePrefab;   // ���� ������ �����Ѵ�.
    public Transform[] boneSpawnPos;  // ���� ������ ��ġ�� ���Ѵ�.

    public float spawnTime = 0.5f; // ���� ������ �ֱ�
    private float TimeCheck;
    // Update is called once per frame
    void Update()
    {
        TimeCheck -= Time.deltaTime;

        if (TimeCheck <= 0)
        {
            int RandomBone = UnityEngine.Random.Range(0, bonePrefab.Length);
            int RandomPos = UnityEngine.Random.Range(0, boneSpawnPos.Length);

            Instantiate(bonePrefab[RandomBone], boneSpawnPos[RandomPos].position, Quaternion.identity);
            TimeCheck = spawnTime;
        }
    }
}
