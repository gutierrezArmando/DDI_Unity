using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;/*Para utilizar el metodo LoadScene */

public class Pauser : MonoBehaviour
{
    public AudioSource music;
	private bool paused = false;
    public GameObject pausePanel;
	public bool isMuted = false;

	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyUp(KeyCode.P))
		{
			paused = !paused;
            pausePanel.SetActive(paused);
		}

		if(paused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}

    public void ContinueGame()
    {
        Debug.Log("Continuar...");
        paused = false;
        pausePanel.SetActive(paused);
    }

    public void ResetGame()
    {
        Debug.Log("Reset...");
        SceneManager.LoadScene(0);
    }

    public void MuteMusic()
    {
        isMuted = !isMuted;
        music.mute = isMuted;
        Debug.Log("Mute...");
    }

}