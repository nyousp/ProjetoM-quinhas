using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class TensaoButton : MonoBehaviour
{
    public string valor_tensao;
    public void duzentos()
    {
         valor_tensao = "220";
    }
    public void trezentos()
    {
         valor_tensao = "380";
    }
    public void quatrocentos()
    {
         valor_tensao = "440";
    }
    public void setecentos()
    {
         valor_tensao = "760";
    }
    public void Exibirvalortensao()
    {
        Console.WriteLine(valor_tensao);
    }
}