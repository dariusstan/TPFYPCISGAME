using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioMenu : MonoBehaviour {
    
    public void BackToMainMenu(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
