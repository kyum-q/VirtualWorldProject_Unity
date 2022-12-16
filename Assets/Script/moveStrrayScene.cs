using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class moveStrrayScene : MonoBehaviour
{


    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        IsOn = false;
        LoadingBar.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //시선 처리 부분
        if (IsOn)
        {
            if (barTime <= 3.0f)
            {
                barTime += Time.deltaTime;
            }

            //바가 다 채워지면
            else
            {
                LoadingBar.fillAmount = 0;
                SceneManager.LoadScene("RealWorkScene");
            }

            LoadingBar.fillAmount = barTime / 3.0f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void SetGazedAt(bool gazedAt)
    {
        IsOn = gazedAt;
        barTime = 0.0f;

        if (gazedAt)
            Debug.Log(" PastWorkroomScene In");
        else
        {
            Debug.Log("PastWorkroomScene Out");
            LoadingBar.fillAmount = 0;
        }
    }

}
