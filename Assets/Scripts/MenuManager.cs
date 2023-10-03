using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public TensaoButton tensaobutton;
    [SerializeField] private string menuinformacoes;
    [SerializeField] private GameObject configmotor;
    [SerializeField] private GameObject configrede;
    [SerializeField] private GameObject start;

    public void App()
    {
        SceneManager.LoadScene(menuinformacoes);
    }
    public void ConfigurarMotor()
    {
        configmotor.SetActive(true);
    }
    public void FecharConfigMotor()
    {
        configmotor.SetActive(false);
    }
    public void ConfigurarRede()
    {
        configrede.SetActive(true);
    }
    public void FecharConfigRede()
    {
        configrede.SetActive(false);
        tensaobutton.Exibirvalortensao();
    }
    public void StartSimulator()
    {
        start.SetActive(true);
    }
}

