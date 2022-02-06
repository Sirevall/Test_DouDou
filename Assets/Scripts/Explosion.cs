using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject PartBombPrefab;
    public GameObject ExplosionPrefab;

    private Animation _anim;

    private void Start()
    {
        _anim = GetComponent<Animation>();
    }
    private void OnMouseDown()
    {
        _anim.Play();
    }
    public void ExplosionBomb()
    {
        Instantiate(ExplosionPrefab, transform.position, transform.rotation);
        CreatePartOfBomb(-0.25f);
        CreatePartOfBomb(0.25f, 180);
        Destroy(gameObject);
    }
    
    private void CreatePartOfBomb(float speed, float rotationZ = 0)
    {
        var inst = Instantiate(PartBombPrefab, transform.position, Quaternion.Euler(0, 0, rotationZ));
        inst.GetComponent<BombPart>().Speed = speed;
    }
}
