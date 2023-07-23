using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //seviyeler için gerekli olan kütüphane

//hero ya player tag ini ekledik

public class Engel : MonoBehaviour
{
    private Scene _scene; //þu an ki sahnemle alakalý ?

    private void Awake() //bulunduðumuz sahneyi fonksiyon çalýþtýðýnda anlamak için
    {
        _scene = SceneManager.GetActiveScene();
        Debug.Log(_scene.name);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))   //eðer obje player ise seviyeyi yeniden baþlatmak için
        {
            Score.lives--;
            SceneManager.LoadScene(_scene.name);
        }
    }

}
