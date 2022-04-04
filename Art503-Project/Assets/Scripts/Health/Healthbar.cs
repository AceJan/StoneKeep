using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Start()
    {
        totalhealthBar.fillAmount = 4;
        
    }

    private void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 4;
        //Debug.Log(currenthealthBar.fillAmount);
    }
}