using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void Retry()
    {
        //MainScene을 불러오기 위해 SceneManager사용
        //"MainScene"이라는 이름의 Scene을 로드해줘라
        SceneManager.LoadScene("MainScene");
    }
}
