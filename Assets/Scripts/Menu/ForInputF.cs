using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ForInputF : MonoBehaviour
{
    private void Start()
    {
        TMP_InputField field = GetComponent<TMP_InputField>();
        if (Manager.Instance.NameBest != "")
            field.text = Manager.Instance.NameBest;
    }
}
