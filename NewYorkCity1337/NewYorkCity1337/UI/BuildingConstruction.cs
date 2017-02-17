using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Input;
using NewYorkCity1337.Sound;
using NewYorkCity1337.TileEngine;
using Sound;

namespace NewYorkCity1337.UI
{
    public class BuildingConstruction : IGameObject
    {
        private MouseState prevState;
        private SelectedTile selectedTile;
        private BuildingSelectionOverlay buildingSelection;
        private SoundEffect buySoundEffect;

        public BuildingConstruction(SelectedTile selectedTile, BuildingSelectionOverlay buildingSelection)
        {
            this.selectedTile = selectedTile;
            this.buildingSelection = buildingSelection;
        }

        public void LoadContent()
        {
            buySoundEffect = new LoadedSoundEffect("cha-ching").Get();
        }

        public void UnloadContent()
        {
            buySoundEffect.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
            var state = Mouse.GetState();
            if (state.LeftButton == ButtonState.Released 
                && prevState.LeftButton == ButtonState.Pressed 
                && buildingSelection.GetSelectedBuilding() != null)
            {
                new CurrentMap().Get().Enter(buildingSelection.GetSelectedBuilding(), selectedTile.GetCurrentSelectedTileLocation());
                buySoundEffect.Play();
            }
                
            prevState = state;
        }

        public void Draw()
        {
        }
    }
}
