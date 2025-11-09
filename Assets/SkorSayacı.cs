using UnityEngine;
public class SkorSayacı : MonoBehaviour
{
    private int _skor;
    //skorumuzu arttırabilmemiz icin bir veri tipi belirledik.

    public void SkorEkle(int amount)
    //voidimizi public yapmamızın sebebi bu scriptte yazdığımız durumu diğer scriptlerimizin içine ekleyebilmektir.
    {
        _skor += amount;
        //skoru arttırmak için yazdık.
        Debug.Log("Score: " + _skor);
    }

    public void SkorEksilt(int amount)
    {
        _skor -= amount;
        Debug.Log("Score Dustu!: " + _skor);
    }
}