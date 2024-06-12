
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    

    // Collider ile çarpışma algılandığında çağrılır
    private void OnCollisionEnter(Collision collision)
    {
        // Çarpışmanın FlagPole objesiyle mi gerçekleştiğini kontrol eder
        if (collision.gameObject.CompareTag("FlagPole"))
        {
            // İkinci sahneye geçiş yapar
            SceneManager.LoadScene("2-2");

        }
    }
}

