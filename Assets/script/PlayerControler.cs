using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float flySpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //dodaj do wsprzdnych wartość x=1, y=0, z=0 pomno�one przez czas
        //mierzony w sekundach od ostatniej klatki
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        //prezentacja działania wyadzonego sterowania (emualcja joystika)
        //Debug.Log(Input.GetAxis("Vertical"));

        //sterowanie prędkości
        //stworz nowy wektor przesunięcia o wartości 1 do przodu
        Vector3 movement = transform.forward;
        //pomn� go przez czas od ostatniej klatki
        movement *= Time.deltaTime;
        //pomn� go przez "wychylenie joystika"
        movement *= Input.GetAxis("Vertical");
        //pomn� przez prędkości lotu
        movement *= flySpeed;
        //dodaj ruch do obiektu
        transform.position += movement;


        //obrt
        //modyfikuj o "Y" obiektu player
        Vector3 rotation = Vector3.up;
        //przemn� przez czas
        rotation *= Time.deltaTime;
        //przemn� przez klawiatur�
        rotation *= Input.GetAxis("Horizontal");
        //pomn� przez prędkości obrotu
        rotation *= rotationSpeed;
        //dodaj obrót do obiektu
        //nie możemy uy += poniewa unity używa Quaternion�w do zapisu rotacji
        transform.Rotate(rotation);

    }
}