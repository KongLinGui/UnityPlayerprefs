using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuJieMianGuanLi : MonoBehaviour {
    public GameObject[] objects;

	void Start () {
        int num = PlayerPrefs.GetInt("PlayerprefsChuCun");
        if (num!=0)
        {
            objects[0].SetActive(false);
            objects[num].SetActive(true);
        }
        else
        {
            objects[num].SetActive(true);
        }      
	}	
}
