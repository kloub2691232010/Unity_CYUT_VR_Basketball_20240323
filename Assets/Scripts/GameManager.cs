using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Replay() 
    {
       SceneManager.LoadScene("�x�y��");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
