using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class health : MonoBehaviour {
    public Slider healthSlider;
    private float maxHealth;
    private float curentHealth;
    public GameObject bohater;
    private Bohater boh;
	void Awake () {
        boh = bohater.GetComponent<Bohater>();
        curentHealth = boh.podajHp();
        maxHealth = curentHealth;
	}
	
	// Update is called once per frame
	void Update () {
        curentHealth = boh.podajHp();
        healthSlider.value = (curentHealth / maxHealth);
	}
}
