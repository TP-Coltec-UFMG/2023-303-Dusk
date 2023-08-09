using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  //Variável para acessar este script pelos outros
    public static GameManager gameManager;
    public GameObject pausePanel;

    // Update is called once per frame
    void Update()
    {

        //Ao apertar esc
        if(Input.GetKeyDown(KeyCode.Escape)){
            
            //Se a tela de pause estiver ligada
            if(pausePanel.activeSelf){
                ResumeGame();

            //Se não
            } else{

                pausePanel.SetActive(true);
                Cursor.visible = true;
                Time.timeScale = 0;
            }
        }
        //Se não
        else{
            Cursor.visible = true;
        }
    }

    //Recomeçar partida
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        Cursor.visible = false;
    }

    //Voltar ao jogo
    public void ResumeGame(){

        pausePanel.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
    }


    //Ir para a tela de menu
    public void NextScene(){
        SceneManager.LoadScene("NovoMenu", LoadSceneMode.Single);
    }
}
