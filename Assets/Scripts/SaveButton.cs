using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveButton : MonoBehaviour
{
    public MenuManager menuManager;
    //Aqui a gente salva o bglh todo, basicamente ele só vai recopiar o que tava escrito no inputfield e dar o aviso no log
    private string textosalvo;
    public InputField inputField;
    public void SalvarTexto()
    {

        if (menuManager == null)
        {
            Debug.LogWarning("Objeto OutroScript não atribuído!");
            return;
        }

        textosalvo = inputField.text;

     Debug.Log("Dados salvos: " + textosalvo);
        menuManager.FecharConfigMotor();
    }
    


}