using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshExplainShow : MonoBehaviour
{
    public GameObject explain;
    private bool IsOn;
    private float endTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //시선 처리 부분
        if (!IsOn)
        {
            if (endTime <= 5.0f)
            {
                endTime += Time.deltaTime;
            }

            else
            {
                explain.SetActive(false);
                IsOn = true;
            }
        }
    }

    public void SetGazedAt(bool gazedAt)
    {
        IsOn = gazedAt;
        endTime = 0.0f;

        if (gazedAt)
            Debug.Log("In");
        else
        {
            Debug.Log("Out");
        }


    }
}
