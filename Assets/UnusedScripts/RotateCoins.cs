using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoins : MonoBehaviour
{
    public float rotatespeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spin());
      
    }
    private IEnumerator Spin()
    {
        while(true)
        {
            transform.Rotate(transform.up * 120 * rotatespeed * Time.deltaTime);
            yield return 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
