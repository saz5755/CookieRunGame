using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    float back = 1f;

    private Material mat;
    private float x;
    private void Awake()
    {
        back = Random.Range(.3f, .8f);
        //mat = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * back;

        /*x += Time.deltaTime;
        x %= 1;

        mat.SetTextureOffset("_MainTex", new Vector2(x, 0));*/

    }


}
