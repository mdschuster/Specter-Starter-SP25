using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    public GameObject MeleeEnemy;
    public GameObject RangedEnemy;
    
    //other information we may want
    public int wave;
    public float meleeChance;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public IProduct produce()
    {
        float x = Random.Range(-10.0f, 10.0f);
        float y = Random.Range(-10.0f, 10.0f);
        float randomNum=Random.Range(0.0f, 1.0f);
        if (randomNum >= meleeChance)
        {
            GameObject go = Instantiate(MeleeEnemy,new Vector3(x,y,0),Quaternion.identity);
            return go.GetComponent<Enemy>();
        }
        else
        {
            GameObject go = Instantiate(RangedEnemy,new Vector3(x,y,0),Quaternion.identity);
            return go.GetComponent<Enemy>();
        }
    }
}
