using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroler : MonoBehaviour
{
    //wspolrzedne gracza 
    Transform player;
    //wysoko�� kamery 
    public float cameraheight = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        //pdolacz pozycje gracza do lokalnej zmiennej korzystajac z jego taga 
        //to nie jest zapisane warto�ci jeden raz tylko referencja do obiektu 
        //to znaczy ze player zawsze bedzie zawieral aktualna pozycje gracza
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //oblicz docelowa pozycje kamery 
        Vector3 targetPosition = player.position + Vector3.up * 10
        //p�ynnie przesu� kamer� w kierunku gracza 
        //funkcja Vector3.Lerp
        //p�ynnie przechodzi z pozycji pierwszego arguentu 
        transform.position = Vector3.Lerp(transform.position, player.position, Time.deltaTime);
    }
}
