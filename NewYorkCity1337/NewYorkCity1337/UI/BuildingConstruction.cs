using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Input;
using NewYorkCity1337.TileEngine;

namespace NewYorkCity1337.UI
{
    public class BuildingConstruction : IGameObject
    {
        private MouseState prevState;
        private SelectedTile selectedTile;
        private BuildingSelectionOverlay buildingSelection;

        public BuildingConstruction(SelectedTile selectedTile, BuildingSelectionOverlay buildingSelection)
        {
            this.selectedTile = selectedTile;
            this.buildingSelection = buildingSelection;
        }

        public void LoadContent()
        {
        }

        public void UnloadContent()
        {
        }

        public void Update(GameTime deltaTime)
        {
            var state = Mouse.GetState();
            if (state.LeftButton == ButtonState.Released && prevState.LeftButton == ButtonState.Pressed && buildingSelection.GetSelectedBuilding() != null)
                new CurrentMap().Get().Enter(buildingSelection.GetSelectedBuilding(), selectedTile.GetCurrentSelectedTileLocation());
            prevState = state;
        }

        public void Draw()
        {
        }
    }
}
