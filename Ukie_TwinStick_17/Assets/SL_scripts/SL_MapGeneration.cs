using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SL_MapGeneration : MonoBehaviour 
{
    [Tooltip("All objects that can be placed in the top left")]
    public GameObject[] mAR_GO_TopLeftObjects;
    [Tooltip("All objects that can be placed in the top right")]
    public GameObject[] mAR_GO_TopRightObjects;
    [Tooltip("All objects that can be placed in the bottom left")]
    public GameObject[] mAR_GO_BottomLeftObjects;
    [Tooltip("All objects that can be placed in the bottom right")]
    public GameObject[] mAR_GO_BottomRightObjects;

    //Positions of the four quadrants
    private Vector3 mV3_TopLeft = new Vector3(-50,0,50);
    private Vector3 mV3_TopRight = new Vector3(50, 0, 50);
    private Vector3 mV3_BottomLeft = new Vector3(-50, 0, -50);
    private Vector3 mV3_BottomRight = new Vector3(50, 0, -50);

    private GameObject mGO_TopLeftSelected;
    private GameObject mGO_TopRightSelected;
    private GameObject mGO_BottomLeftSelected;
    private GameObject mGO_BottomRightSelected;

    // Use this for initialization
	void Start () 
    {
        GetRandomPieces();
        ConstructMap();
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    private void ConstructMap() //instantiate each piece in it's home
    {
        Instantiate(mGO_TopLeftSelected, mV3_TopLeft, Quaternion.identity);
        Instantiate(mGO_TopRightSelected, mV3_TopRight, Quaternion.identity);
        Instantiate(mGO_BottomLeftSelected, mV3_BottomLeft, Quaternion.identity);
        Instantiate(mGO_BottomRightSelected, mV3_BottomRight, Quaternion.identity);
    }

    private void GetRandomPieces()
    {
        mGO_TopLeftSelected = mAR_GO_TopLeftObjects[Random.Range(0, mAR_GO_TopLeftObjects.Length)]; //select a top left thing
        mGO_TopRightSelected = mAR_GO_TopRightObjects[Random.Range(0, mAR_GO_TopRightObjects.Length)]; //select a top right thing
        mGO_BottomLeftSelected = mAR_GO_BottomLeftObjects[Random.Range(0, mAR_GO_BottomLeftObjects.Length)]; //select a bottom left thing
        mGO_BottomRightSelected = mAR_GO_BottomRightObjects[Random.Range(0, mAR_GO_BottomRightObjects.Length)]; //select a bottom right thing
    }
}
