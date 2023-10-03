using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NumericInputField : MonoBehaviour
{
    public InputField inputField;

    private void Start()
    {
        // Adicione um listener para chamar a função de validação sempre que houver uma alteração no campo
        inputField.onValueChanged.AddListener(delegate { ValidateInput(); });
    }

    private void ValidateInput()
    {
        // Remove todos os caracteres que não são números
        inputField.text = new string(inputField.text.Where(char.IsDigit).ToArray());

        string inputText = inputField.text;
        Debug.Log("Texto do Input Field: " + inputText);
    }
}
