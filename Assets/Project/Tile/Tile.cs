using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public List<Tile> neighborTiles { get; private set; } = new List<Tile>();
    public Unit unitOnTile { get; private set; }
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddNeighborTile(Tile tile)
    {
        neighborTiles.Add(tile);
    }
    public void UnitEnterTile(Unit unit)
    {
        unitOnTile = unit;
    }
    public void UnitLeaveTile()
    {
        unitOnTile = null;
    }
}
