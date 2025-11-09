using UnityEngine;
public class puantrigger : MonoBehaviour
{
    [SerializeField] private SkorSayacı skorsayacı;
    // konsolda görünmesi icin yazdık.
    private void Start()
    {
        skorsayacı = GameObject.Find("SkorSayacı").GetComponent<SkorSayacı>();
        //gameobject olan skor sayacımızı scriptin icine sürükleyemediğimiz icin bu kodu yazdık.
    }

    private void OnTriggerEnter(Collider other)
    // objemizin triggerla etkileşime girmesi ile çalışan kod.
    {
        switch (this.tag)
        //bu koda sahip objenin tagını referans almak icin this.tag yazdık.
        {
            case "Avokado":
                //this.tag avokadoyu belirtiyor.
                skorsayacı.SkorEkle(2);
                //skorsayacını diğer scriptimize eşitledik ve bu scriptin içindeki kodu aktifleştirdik.
                Destroy(this.gameObject);
                //objenin yok olması için yazdık.
                break;
            
            case "Muz":
                skorsayacı.SkorEkle(3);
                Destroy(this.gameObject);
                break;

            case "Sarımsak":
                skorsayacı.SkorEkle(1);
                Destroy(this.gameObject);
                break;

            case "Karpuz":
                skorsayacı.SkorEkle(5);
                Destroy(this.gameObject);
                break;

            case "Hamburger":
                skorsayacı.SkorEksilt(3);
                Destroy(this.gameObject);
                break;
        }

    }
    private void OnCollisionEnter(Collision other)
    //objeye çarptığında çalışması için yazdık.
    {
        if (other.gameObject.tag == "Ground")
            //eğer çarptığımız objenin tagı ground ise çalışır.
        {
            Destroy(this.gameObject);
        }
    }
}