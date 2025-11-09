using UnityEngine;

public class Hareket : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3.5f; 
    // hareket etme hızını istediğimiz zaman unity üzerinden değiştirebilmek için [SerializeField] ı yazdık.

    private void Update()
    {
        hareket();
    }

    private void hareket()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        // float horizontal = Yürümek için kullandığımız tuşun ataması
        // Input.GetAxisRaw = akıcı değil

        Vector3 direction = new Vector3(horizontal, 0f, 0f);
        // karakterin hangi yöne gidiceğini belirlemek için Vector3 ü ekledik


        transform.Translate(direction * (moveSpeed * Time.deltaTime), Space.World);
        // transform.Translate = karakteri hareket ettirmek için kullandığımız komut 
        // Time.deltaTime = oyunu oynayan herkes eşit hızda geçebilsin diye yazdık
    }
} 

