using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SL_GameManager : MonoBehaviour 
{
    private GameObject[] mAR_GO_enemySpawners;
    public List<Image> mLS_IM_Hearts = new List<Image>();
    public int mIN_playerHP = 3;
    private int mIN_playerHPMax = 6;
    private Canvas mCAN_playCanvas;

    public Image mIM_Heart;

	// Use this for initialization
	void Start ()
    {
        mCAN_playCanvas = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();
        DrawHearts();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (mIN_playerHP > mIN_playerHPMax)
        {
            mIN_playerHP = mIN_playerHPMax;
        }

        if(mIN_playerHP <= 0)
        {
            print("DEAD");
        }
	}

    void CompileSpawners()
    {
        mAR_GO_enemySpawners = GameObject.FindGameObjectsWithTag("Spawner");
    }

    public void DrawHearts()
    {
        foreach(Image IM in mLS_IM_Hearts)
        {
            Destroy(IM);
        }

        for (int i = 0; i <= mIN_playerHP-1; i++)
        {
            GameObject heart = Instantiate(mIM_Heart, transform.position, Quaternion.identity).gameObject;
            mLS_IM_Hearts.Add(heart.GetComponent<Image>());

            heart.transform.SetParent(mCAN_playCanvas.transform);

            heart.GetComponent<Image>().rectTransform.anchorMin = new Vector2(0, 1);
            heart.GetComponent<Image>().rectTransform.anchorMax = new Vector2(0, 1);
            heart.GetComponent<Image>().rectTransform.pivot = new Vector2(0, 1);

            heart.GetComponent<Image>().rectTransform.anchoredPosition3D = new Vector3(i * 100 + i * 5, -5, 0) + new Vector3(5, 0, 0);
            heart.GetComponent<Image>().rectTransform.localScale = Vector3.one;
            heart.GetComponent<Image>().rectTransform.localRotation = Quaternion.Euler(Vector3.zero);
            
        }
    }


}
