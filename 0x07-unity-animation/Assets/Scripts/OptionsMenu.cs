using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;


public class OptionsMenu : MonoBehaviour
{
    public Slider bgmSlider;
    public Slider sfxSlider;
    public Toggle invertYAxis;
    public void Back()
	{
		if (invertYAxis.isOn)
			invertYAxis.isOn = false;
		SceneManager.LoadScene(PlayerPrefs.GetString("lastScene"));
	}

	public void Apply()
	{
		if (invertYAxis.isOn)
			PlayerPrefs.SetInt("isInverted", 1);
		else
			PlayerPrefs.SetInt("isInverted", 0);

		SceneManager.LoadScene(PlayerPrefs.GetString("lastScene"));
	}
}
