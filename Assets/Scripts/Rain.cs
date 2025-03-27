using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.4f, 2.4f);
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //충돌이벤트 발생시
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision에는 충돌하는 물체의 정보가 들어있다.
        //즉, Rain이 Ground에 부딪히면 부딪힌 Ground 관련된 게임 오브젝트 정보들이 들어있다
        if(collision.gameObject.CompareTag("Ground"))
        {
            //gameObject는 Rain스크립트가 붙어있는 오브젝트(Rain)자체를 가리킴
            Destroy(gameObject);
        }
    }
}
