using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

	public string nomeDoFilho = "GameOver";

	[SerializeField] TextMeshProUGUI textoTimer;
	[SerializeField] float tempoRestante;
	
	public bool acabou =false;


	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Transform filho = transform.Find(nomeDoFilho);
		filho.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if (tempoRestante > 0)
		{
			tempoRestante = tempoRestante - Time.deltaTime;
		}
		else
		{
			tempoRestante = 0;
			textoTimer.color = Color.red;
			Time.timeScale = 0f;
			acabou = true;
	
			Transform filho = transform.Find(nomeDoFilho);
			filho.gameObject.SetActive(true);


		}

	int minutos = Mathf.FloorToInt(tempoRestante / 60);
	int segundos = Mathf.FloorToInt(tempoRestante % 60);

	textoTimer.text = string.Format("{0:00}:{1:00}", minutos, segundos);


    }
}
