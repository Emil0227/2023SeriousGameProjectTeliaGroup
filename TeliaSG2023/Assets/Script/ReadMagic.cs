using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn;
using Yarn.Unity;

public class ReadMagic : MonoBehaviour
{


public IVariableStorage variableStorage;
public Text MagicValueText;
    void Update()
    {
    variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
    float testVariable;
    variableStorage.TryGetValue("$magic", out testVariable);
    MagicValueText.text=testVariable.ToString();
    }

}
