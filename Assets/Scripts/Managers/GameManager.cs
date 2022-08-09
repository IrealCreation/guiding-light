using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Main;
    
    public Player Player;
    public List<Enemy> Enemies; // Everybody wants to be...
    
    // Start is called before the first frame update
    void Start()
    {
        Main = this;
        Enemies = FindObjectsOfType<Enemy>().ToList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayerMoved()
    {
        // Update the distance of each enemy
        foreach (Enemy enemy in Enemies)
        {
            enemy.UpdateDistanceToPlayer(Player);
        }
        
        // Update the enemy sources of the player
        foreach (Enemy enemy in Enemies)
        {
            Player.UpdateEnemySource(enemy);
        }
    }
}
