using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    float direction = 0.05f;

    SpriteRenderer renderer;   
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;   // 다른기기 속도 맞춰줌
        renderer = GetComponent<SpriteRenderer>(); // Inspector의 SpriteRenderer를 가져옴	 
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 클릭 했을
        if (Input.GetMouseButtonDown(0)) 
        {
            direction *= -1;    // 방향반전 
            renderer.flipX = !renderer.flipX; // rendere의 flipX값을 반전(이미지 좌우 반전)
        }
        // 오른쪽벽에 닿으면 
        if (transform.position.x > 2.6f) 
        {
            renderer.flipX = true;  // 이미지반전(flipx 체크)
            direction = -0.05f; // 왼쪽으로 출발
        }
        // 왼쪽벽에 닿으면 
        if (transform.position.x< -2.6f) 
        {
            renderer.flipX = false; // 이미지 반전(flipx 체크 품) 
            direction = 0.05f;  // 오른쪽으로 출발
        }

        transform.position += Vector3.right * direction;
    }
}
