using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
// randomun scriptini çekiyoruz.

public class MeyveSpawner : MonoBehaviour
{
    public GameObject[] meyveler;
    // [] = dizileri belirlemek için yazdık
    private float SpawnTimer = 2f;
    //spawnlama süremizi belirtiyoruz.
    private float timer;
    //süremizi belirtmek icin onceden atadığımız veri tipi.

    private void Update()
    {
        timer += Time.deltaTime;
        //belirlediğimiz veri tipini oyunda geçen süreye eşitliyoruz.
        if (timer > SpawnTimer)
            // oyundaki zamanımız belirlediğimiz spawn timer ı gecerse bu komut calısıcak.
        {
            RandomSpawn();
            timer = 0;
            // komutun tekrar calısması icin spawnımızı calıstırıp zamanı tekrar 0 a eşitler.
        }
    }

    void RandomSpawn()
    {


        int RandomIndex = Random.Range(0, meyveler.Length);
        // diziyi rastgele seçmek için yazdık.Diziler 0 dan başlar.
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-5,8),15, -5);
        //belirlediğimiz konumlar arasında rastgele spawn olması için yazıyoruz.

        Instantiate(meyveler[RandomIndex], randomSpawnPosition, Quaternion.identity);
        //spawnlama komutumuz:spawn ediceğimiz objeler,konum,   rotasyon.
    }
}