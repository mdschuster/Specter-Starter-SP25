using UnityEngine;

public class Weapon : MonoBehaviour
{
    public ParticleSystem weaponProjectile;
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = cam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        dir.Normalize();
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle-90f, Vector3.forward);
        transform.rotation = rotation;

        if (Input.GetMouseButtonDown(0))
        {
            weaponProjectile.Play();
        }
    }
}
