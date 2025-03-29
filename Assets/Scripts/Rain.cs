using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    float size = 1.0f;
    int score = 1;

    //색깔설정은 SpriteRender에 있어서 이를 가져오기 위함 
    SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        //Sprite Renderer컴포넌트를 GetComponent를 통해 가져온다
        //스크립트와 같은 자리에 있어야함
        renderer = GetComponent<SpriteRenderer>();

        float x = Random.Range(-2.4f, 2.4f);
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);

        //정수값을 넣어주면 정수만 추출됨(최댓값은 포함이 되지않음)
        int type = Random.Range(1, 4);

        if(type==1)
        {
            size = 0.8f;
            score = 1;
            renderer.color = new Color(100 / 255f, 100 / 255f, 1f, 1f);
        }
        else if (type == 2)
        {
            size = 1.0f;
            score = 2;
            renderer.color = new Color(130 / 255f, 130 / 255f, 1f, 1f);
        }
        else if (type == 3)
        {
            size = 1.2f;
            score = 3;
            renderer.color = new Color(150 / 255f, 150 / 255f, 1f, 1f);
        }

        transform.localScale = new Vector3(size, size, 0);
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

        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(score);
            Destroy(gameObject);
        }
    }
}
