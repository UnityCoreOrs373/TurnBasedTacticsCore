using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    [TestFixture]
    public class TileTests
    {
        Tile tile;
        // A Test behaves as an ordinary method
        [SetUp]
        public void SetUp()
        {
            GameObject tileGameObject = new GameObject();
            tile = tileGameObject.AddComponent<Tile>();
        }
        [Test]
        public void AddNeighborTile_NeighborTiles_ContainsTile()
        {
            // Use the Assert class to test conditions
            
            //GameObject tileGameObject1 = new GameObject();
            //Tile tile1= tileGameObject1.AddComponent<Tile>();

            GameObject tileGameObject2 = new GameObject();
            Tile neighborTile= tileGameObject2.AddComponent<Tile>();

            GameObject tileGameObject3 = new GameObject();
            Tile nonNeighborTile= tileGameObject3.AddComponent<Tile>();

            tile.AddNeighborTile(neighborTile);

            Assert.True(tile.neighborTiles.Contains(neighborTile));
            Assert.False(tile.neighborTiles.Contains(nonNeighborTile));
        }
        [Test]
        public void UnitEnterTile_Unit_EqualsUnit()
        {
            GameObject gameObject = new GameObject();
            Unit unit = gameObject.AddComponent<Unit>();

            tile.UnitEnterTile(unit);
            Assert.AreEqual(unit, tile.unitOnTile);


        }
        [Test]
        public void UnitLeaveTile_Unit_Null()
        {
            GameObject gameObject = new GameObject();
            Unit unit = gameObject.AddComponent<Unit>();

            tile.UnitEnterTile(unit);
            tile.UnitLeaveTile();

            Assert.AreEqual(tile.unitOnTile,null);


        }
    }
}
