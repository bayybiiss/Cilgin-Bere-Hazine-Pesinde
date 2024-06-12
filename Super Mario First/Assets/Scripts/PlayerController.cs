
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    

    // Collider ile çarpýþma algýlandýðýnda çaðrýlýr
    private void OnCollisionEnter(Collision collision)
    {
        // Çarpýþmanýn FlagPole objesiyle mi gerçekleþtiðini kontrol eder
        if (collision.gameObject.CompareTag("FlagPole"))
        {
            // Ýkinci sahneye geçiþ yapar
            SceneManager.LoadScene("2-2");

        }
    }
}

