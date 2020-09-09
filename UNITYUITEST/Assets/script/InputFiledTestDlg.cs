using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFiledTestDlg : MonoBehaviour
{
    public Text m_ResultText = null;
    public InputField m_InputName = null;
    public Button m_btnStart = null;
    // Start is called before the first frame update
    void Start()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);

        initialize();
    }
    public void initialize()
    {

    }
    public void OnClicked_Start()
    {
        string sValue = m_InputName.text;

        if(m_InputName.text == "")
        {
            m_ResultText.text = "없어용";
            return;
        }

        string sRes = "당신이 입력한 이름은" + sValue + "입니다.";
        m_ResultText.text = sRes;
        
    }

    public void OnClicked_Clear()
    {
        m_ResultText.text = "정리 되었습니다.";
        m_InputName.text = "";
    }
     
    void Update()
    {
        
    }
}
