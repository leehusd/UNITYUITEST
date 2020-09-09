using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupTestDlg : MonoBehaviour
{
    [SerializeField] ToggleGroup m_ToggleGroup = null;
    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnResult=null;

    string m_sValue = "";
    // Start is called before the first frame update
    void Start()
    {
        m_btnResult.onClick.AddListener(OnClicked_Result);
        m_sValue = "사과";
    }

    public void OnClicked_Result()
    {
        string strResult = "당신이 선택한 과일은" + m_sValue;
        m_txtResult.text = strResult;
    }

    public void OnChanged_Toggle(int iIndex)
    {
        string[] aName = { "사과", "배", "오렌지" };
        m_sValue = aName[iIndex];
    }

    public void Onclicked_Clear()
    {

        m_txtResult.text = "출력"; 
        m_ToggleGroup.SetAllTogglesOff();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
