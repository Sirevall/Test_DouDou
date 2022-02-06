using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEmmiter : MonoBehaviour
{
    public GameObject BombPrefab;

    private void Start()
    {
        StartCoroutine(BombSpawn());
    }
    IEnumerator BombSpawn()
    {
        while (Application.isPlaying)
        {
            CreateBomb();
            yield return new WaitForSeconds(2);
        }
        
    }
    private void CreateBomb()
    {
        Instantiate(BombPrefab, transform.position, transform.rotation);
    }
}
