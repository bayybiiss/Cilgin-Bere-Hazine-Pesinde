
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    

    // Collider ile �arp��ma alg�land���nda �a�r�l�r
    private void OnCollisionEnter(Collision collision)
    {
        // �arp��man�n FlagPole objesiyle mi ger�ekle�ti�ini kontrol eder
        if (collision.gameObject.CompareTag("FlagPole"))
        {
            // �kinci sahneye ge�i� yapar
            SceneManager.LoadScene("2-2");

        }
    }
}

