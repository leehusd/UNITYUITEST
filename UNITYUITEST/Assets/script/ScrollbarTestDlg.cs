using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarTestDlg : MonoBehaviour
{

    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnResult = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] Scrollbar m_ScrollBarNum = null;


    // Start is called before the first frame update
    void Start()
    {
        m_btnResult.onClick.AddListener(OnClicked_Result);
        m_btnClear.onClick.AddListener(Onclicked_Clear);


    }
    public void initialize()
    {

    }
    public void OnValueChanged_ScrollBar()
    {
        string strValue = "" + m_ScrollBarNum.value;
        m_txtResult.text = strValue;
    }

    public void OnClicked_Result()
    {
        float fValue = m_ScrollBarNum.value;
        string strResult = "현재값은"+ fValue +"입니다";
        m_txtResult.text = strResult;
    }
    public void Onclicked_Clear()
    {
        m_txtResult.text = "출력";
        m_ScrollBarNum.value = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
