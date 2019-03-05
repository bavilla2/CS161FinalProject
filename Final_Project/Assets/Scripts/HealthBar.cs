using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class HealthBar : MonoBehaviour
{
    TextMeshProUGUI Health_Text;
    float Player_Health;

    // Start is called before the first frame update
    void Start()
    {
        Health_Text = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Player_Health = GameObject.Find("Player").GetComponent<Player>().health;
        Health_Text.text = string.Format("Chill {0:0}", Player_Health);
    }
}
