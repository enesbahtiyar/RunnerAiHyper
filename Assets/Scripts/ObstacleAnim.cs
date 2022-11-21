using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnim : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float strength = 2.5f;
    float randomOffSet;
    // Start is called before the first frame update
    void Start()
    {
        randomOffSet = Random.Range(-3.5f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Sin(Time.time * speed + randomOffSet) * strength;
        transform.position = pos;
    }
}
