using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public void Reiniciar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Cerrar()
    {
        Application.Quit();
    }
}
