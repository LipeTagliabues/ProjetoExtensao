using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spa : MonoBehaviour
{

    public GameObject prefab;
    public float spawnTime;
    private float timeCount;
    private Transform canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvas").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;

        if(timeCount >= spawnTime)
        {
            GameObject go = Instantiate(prefab);
            RectTransform rectSpawner = gameObject.GetComponent<RectTransform>();
            go.GetComponent<RectTransform>().anchoredPosition = new Vector3(rectSpawner.anchoredPosition.x, rectSpawner.anchoredPosition.y);
            go.transform.SetParent(canvas, worldPositionStays:false);
            Destroy(go, 50f);
            timeCount = 0;
        }
    }
}
