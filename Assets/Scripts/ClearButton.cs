using UnityEngine;
using UnityEngine.UI;

public class ClearButton : MonoBehaviour
{
    public InputField inputField;

    public void ClearText()
    {
        inputField.text = ""; // Define o texto do InputField como uma string vazia
    }
}
