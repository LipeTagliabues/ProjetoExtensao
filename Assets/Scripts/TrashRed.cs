using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class TrashRed : MonoBehaviour
{
    public Rigidbody2D rbd2;
    public float speed;
    private RectTransform rectTransform;
    [SerializeField] Lixeira pointsController;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(-90, 90)));
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        // rbd2.MovePosition(rectTransform.anchoredPosition + Vector2.down * speed * Time.deltaTime);
        rectTransform.anchoredPosition += Vector2.down * speed * Time.deltaTime;
    }

}
