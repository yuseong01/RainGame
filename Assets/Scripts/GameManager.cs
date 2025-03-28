using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject rain;

    public Text totalScoretxt;

    int totalScore;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //"함수의 이름", 몇 초 이후에 생성할래?, 얼마나 자주 생성할래?(주기)
        InvokeRepeating("MakeRain", 0f, 1f); //MakeRain함수, 바로생성, 1초마다 한번씩 생성
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeRain()
    {
        //생성함수 - 생성하고 싶은 붕어빵 틀, 즉 프리팹을 넣어주면 됨 
        Instantiate(rain);
    }

    //캐릭터와 빗물이 맞았을 때 호출
    public void AddScore(int score)
    {
        totalScore += score;
        //숫자를 문자열로 toString()
        totalScoretxt.text = totalScore.ToString();
    }
}
