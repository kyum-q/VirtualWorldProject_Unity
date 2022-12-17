
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class cshText : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI text;
    public Text text2;
    int num;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        num = (int)time;
        num %= 24;
        switch (num)
        {
            case 0:
                {
                    text.text = "이 작품은 고흐가 1886년 파리로 거처를 옮긴 후 대도시의 삶에서 오는 중압감을 견디지 못하고 남프랑스에 위치한 아를로 떠났을 때의 그림이야.";
                    text2.text = "1/4";
                    break;
                }
            case 8:
                {
                    text.text = "생레미의 정신병원에 입원할 때까지 고흐는 아를에 1년 3개월 가량을 머물렀어. " +
                        " 생레미 시절의 고흐 특유의 붓질과 내면의 감정과 영혼이 투사된  채색기법이 절정에 달했지. ";
                    text2.text = "2/4";
                    break;
                }
            case 16:
                {
                    text.text = "고흐는 홀로, 철저하게, 광기를 내뿜으며 캔버스와 사투를 벌였고 고흐의 방식으로 세상의 무관심을 조롱 했어." +
                    " 그 중심에 있는 작품이 바로 이 '별이 빛나는 밤' 작품이야. ";
                    text2.text = "3/4";

                    break;
                }
            case 24:
                {
                    text.text = "1889년 6월 생레미의 정신병원에서 요양하던 중 고향의 밤 풍경을 그리워하며 그린 그림이야. 그가 그리워 하던 밤 풍경은 이런 밤하늘이지 않았을까?";
                    text2.text = "4/4";
                    break;
                }

        }
    }
}

