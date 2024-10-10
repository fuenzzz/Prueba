using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comida : MonoBehaviour
{
    public BoxCollider2D areaAlrededor;

    // Start is called before the first frame update
    void Start()
    {
        RandomPosicion();
    }

    void RandomPosicion()
    {
        Bounds limites = areaAlrededor.bounds;

        float X = Random.Range(limites.min.x, limites.max.x);
        float Y = Random.Range(limites.min.y, limites.max.y);

        transform.position = new Vector3(Mathf.Round(X), Mathf.Round(Y), 0); ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("serpiente"))
        {
            RandomPosicion();
        }
    }

}
