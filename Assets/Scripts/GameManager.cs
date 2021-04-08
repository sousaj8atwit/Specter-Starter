using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   private static GameManager _instance = null;
   /// <summary>
   /// Awake is called when the script instance is being loaded.
   /// </summary>
   void Awake()
   {
       if(_instance == null){
           _instance = this;
       }else{
           Destroy(this);
       }
   }

   public static GameManager instance(){
       return _instance;
   }

    private GameState state;
    public Player player;


   /// <summary>
   /// Start is called on the frame when a script is enabled just before
   /// any of the Update methods is called the first time.
   /// </summary>
   void Start()
   {
       state = new Play();
   }

   /// <summary>
   /// Update is called every frame, if the MonoBehaviour is enabled.
   /// </summary>
   void Update()
   {
       state = state.process();
   }

    //called every update fram from the state machine
   public void entityAction()
   {
       //move the player and the bosses and enemies, make enemies attack
       player.move();
   }
}
