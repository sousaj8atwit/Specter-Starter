using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : IFactory
{

    private Enemy rangedEnemy;
    private Enemy meleEnemy;

    private int currentWave;

    public EnemyFactory(Enemy ranged, Enemy mele)
   {
       
       this.rangedEnemy = ranged;
       this.meleEnemy = mele;
       currentWave = 0;
   }

   public IProduct produce()
   {
       //Return whatever this factory should produce
       //for this it will produce enemies
       float meleChance = 0.5f;
       float x = Random.Range(-10f,-10);
       float y = Random.Range(-10f, 10);
       float rand = Random.Range(0f,1f);

       if(rand <= meleChance)
       {
           //spawn mele
           return spawnEnemy(meleEnemy,x,y);

       }else
       {
           //spawn ranged
           return rangeEnemy(rangedEnemy,x,y);
       }
   }

   private IProduct spawnEnemy(Enemy prefab, float x, float y)
   {
       return Object.Instantiate(prefab,new Vector3(x,y,0f),Quaternion.identity);
   }
   private IProduct rangeEnemy(Enemy prefab, float x, float y)
   {
       return Object.Instantiate(prefab,new Vector3(x,y,0f),Quaternion.identity);
   }
}
