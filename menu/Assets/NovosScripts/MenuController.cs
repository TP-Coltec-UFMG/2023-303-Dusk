using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void NextScene(){
        //Ir para a tela do jogo
        SceneManager.LoadScene("Lvl1", LoadSceneMode.Single);
        //Tempo correndo normalmente
        Time.timeScale = 1;
    }
    
    public void Quit(){
        //Sair do jogo
        Application.Quit();
        Debug.Log(" Quit game!");
    }
    
}