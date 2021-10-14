using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits_Display : MonoBehaviour
{
    [SerializeField]
    private GameObject _jorgeButton, _arvindButton, _barisButton, _arvindTop, _barisTop, _jorgeCredits, _arvindCredits, _barisCredits, _backCredits, _mainBack;
    public void Jorge()
    {
        _arvindButton.gameObject.SetActive(false);
        _barisButton.gameObject.SetActive(false);
        // _mainBack.gameObject.SetActive(false);
        _jorgeCredits.gameObject.SetActive(true);
        _backCredits.gameObject.SetActive(true);
    }

    public void CreditsBack()
    {
        _arvindButton.gameObject.SetActive(true);
        _jorgeButton.gameObject.SetActive(true);
        _barisButton.gameObject.SetActive(true);
        _mainBack.gameObject.SetActive(true);
        _arvindCredits.gameObject.SetActive(false);
        _jorgeCredits.gameObject.SetActive(false);
        _barisCredits.gameObject.SetActive(false);
        _barisTop.gameObject.SetActive(false);
        _arvindTop.gameObject.SetActive(false);
        _backCredits.gameObject.SetActive(false);
    }
}
