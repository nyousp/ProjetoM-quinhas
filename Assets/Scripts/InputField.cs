using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NumericInputField : MonoBehaviour
{
    public InputField inputField;

    private void Start()
    {
        // Adicione um listener para chamar a fun��o de valida��o sempre que houver uma altera��o no campo
        inputField.onValueChanged.AddListener(delegate { ValidateInput(); });
    }

    private void ValidateInput()
    {
        // Remove todos os caracteres que n�o s�o n�meros
        inputField.text = new string(inputField.text.Where(char.IsDigit).ToArray());

        string inputText = inputField.text;
        Debug.Log("Texto do Input Field: " + inputText);
    }
}
