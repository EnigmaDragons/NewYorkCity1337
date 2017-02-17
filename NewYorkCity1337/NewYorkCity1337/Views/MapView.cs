using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using NewYorkCity1337.Business;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Input;
using NewYorkCity1337.Terrain;
using NewYorkCity1337.TileEngine;
using NewYorkCity1337.Tiles;
using NewYorkCity1337.UI;
using NewYorkCity1337.WorldObjects;

namespace NewYorkCity1337.View
{
    public class MapView : IGameView
    {
        private readonly List<IGameObject> objs = new List<IGameObject>();

        public MapView()
        {
            var road = new Random(Guid.NewGuid().GetHashCode()).Next(1, 16);
            var map = new Map(Enumerable.Range(0, 16).SelectMany(x => Enumerable.Range(0, 16)
                .Select(y => x == road ? new Grass(new TileLocation(x, y), new Road()) : new Grass(new TileLocation(x, y)))));
            new CurrentMap().SetMap(map);
            var moneyAccount = new MoneyAccount();
            objs.Add(map);
            var selectedTile = new SelectedTile();
            objs.Add(selectedTile);
            var buildingSelection = new BuildingSelectionOverlay();
            objs.Add(buildingSelection);
            objs.Add(new BuildingConstruction(moneyAccount, selectedTile, buildingSelection));
            objs.Add(new MoneyAccountOverlay(moneyAccount, new Vector2(100, 10)));

        }

        public void LoadContent()
        {
            objs.ForEach(x => x.LoadContent());
        }

        public void UnloadContent()
        {
            objs.ForEach(x => x.UnloadContent());
        }

        public void Update(GameTime deltaTime)
        {
            objs.ForEach(x => x.Update(deltaTime));
        }

        public void Draw()
        {
            objs.ForEach(x => x.Draw());
        }
    }
}
