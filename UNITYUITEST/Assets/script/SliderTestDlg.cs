using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTestDlg : MonoBehaviour
{

    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnResult = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] Slider m_sliderNum = null;

    [SerializeField] int m_MinValue = 0;
    [SerializeField] int m_MaxValue = 100;
    // Start is called before the first frame update
    void Start()
    {
        m_btnResult.onClick.AddListener(OnClicked_Result);
        m_btnClear.onClick.AddListener(Onclicked_Clear);

        initialize();
    }

    public void initialize()
    {
        m_sliderNum.minValue = m_MinValue;
        m_sliderNum.maxValue = m_MaxValue;
        m_sliderNum.value = 0;
    }

    public void OnValueChanged_SliderNumver()
    {
        int intValue = (int)m_sliderNum.value;
        //string str = m_sliderNum.value.ToString(); // 문자열로 바꿔줌
        m_txtResult.text = intValue.ToString();
    }
    public void OnClicked_Result()
    {
        float fValue = m_sliderNum.value;
        int f2Value = (int)fValue;
        string strResult = "현재값은" + f2Value + "입니다";
        m_txtResult.text = strResult;
    }

    public void Onclicked_Clear()
    {

        m_txtResult.text = "출력";
        m_sliderNum.value = 0;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
