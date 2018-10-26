using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambiarEcena : MonoBehaviour
{

    public void NuevaEcena(int Escena)
    {
        SceneManager.LoadScene(Escena);
	}
}
