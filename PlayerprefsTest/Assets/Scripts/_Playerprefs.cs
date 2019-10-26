using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Playerprefs : MonoBehaviour {

    public void SetShuJu(int num)
    {
        SceneManager.LoadScene(num);
        PlayerPrefs.SetInt("PlayerprefsChuCun", num);
    }

    public void FanHui()
    {
        PlayerPrefs.SetInt("PlayerprefsChuCun", 0);
    }

    public void GetShuJu()
    {
        SceneManager.LoadScene(0);
    }
}
