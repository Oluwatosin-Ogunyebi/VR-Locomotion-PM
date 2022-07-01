using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBullet : MonoBehaviour
{
    private Color _materialColor;

    public MeshRenderer _bulletMR;

    private void Awake()
    {
        _materialColor = Random.ColorHSV();
        _bulletMR.material.color = _materialColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MeshRenderer>() != null)
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = _bulletMR.material.color;
        }
    }
}
