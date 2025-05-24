using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestoryOnContact : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // ������ ������մϴ�.
            SceneManager.LoadScene(0);
        }
        
        Destroy(gameObject);
    }
}
