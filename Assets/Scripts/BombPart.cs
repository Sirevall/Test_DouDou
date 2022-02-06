using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPart : MonoBehaviour
{
    public float Speed;
    private void Start()
    {
        StartCoroutine(DestroyBomb());
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(Speed, 0, 0);  
    }
    IEnumerator DestroyBomb()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
