using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameOver = false;
    public float RestartDeleay;

    public void EndGame() {
        if (!GameOver) {
            GameOver = true;

            Invoke("Restart", RestartDeleay);
        }
    }


    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public bool IsGameRunning() {
        return GameOver;
    }
}
