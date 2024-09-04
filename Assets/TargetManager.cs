using UnityEngine;
using System.Collections.Generic;

public class TargetManager : MonoBehaviour
{
    public GameObject[] targetPrefabs;
    public int maxTargets = 3;

    private List<GameObject> activeTargets = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < maxTargets; i++)
        {
            SpawnTarget(i);
        }
    }

    void SpawnTarget(int index)
    {
        GameObject target = Instantiate(targetPrefabs[index], targetPrefabs[index].transform.position, Quaternion.identity);
        target.GetComponent<MoveTarget>().enabled = true;
        activeTargets.Add(target);
    }
}