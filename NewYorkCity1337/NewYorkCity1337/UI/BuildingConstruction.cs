﻿using Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using NewYorkCity1337.Buildings;
using NewYorkCity1337.Business;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Input;
using NewYorkCity1337.Sound;
using NewYorkCity1337.TileEngine;

namespace NewYorkCity1337.UI
{
    public class BuildingConstruction : IGameObject
    {
        private MouseState prevState;
        private SelectedTile selectedTile;
        private BuildingSelectionOverlay buildingSelection;
        private SoundEffect buySoundEffect;
        private SoundEffect insufficientCashSoundEffect;
        private MoneyAccount moneyAccount;

        private Building selectedBuilding;

        public BuildingConstruction(MoneyAccount moneyAccount, SelectedTile selectedTile, BuildingSelectionOverlay buildingSelection)
        {
            this.moneyAccount = moneyAccount;
            this.selectedTile = selectedTile;
            this.buildingSelection = buildingSelection;
        }

        public void LoadContent()
        {
            buySoundEffect = new LoadedSoundEffect("cha-ching").Get();
            insufficientCashSoundEffect = new LoadedSoundEffect("invalid").Get();
        }

        public void UnloadContent()
        {
            buySoundEffect.Dispose();
            insufficientCashSoundEffect.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
            IfMouseIsOnScreen.Execute(mouse =>
            {
                if (mouse.LeftButton == ButtonState.Released && prevState.LeftButton == ButtonState.Pressed)
                    if (IsBuildingSelected() && buildingSelection.GetSelectedBuilding() == selectedBuilding)
                        if (moneyAccount.EnoughMoney(buildingSelection.GetSelectedBuilding().Price))
                            BuyBuilding();
                        else
                            NotifyInsufficientFunds();
                    else
                        selectedBuilding = buildingSelection.GetSelectedBuilding();

                prevState = mouse;
            });

        }

        private void NotifyInsufficientFunds()
        {
            insufficientCashSoundEffect.Play();
        }

        private void BuyBuilding()
        {
            var building = buildingSelection.GetSelectedBuilding().Clone();
            moneyAccount.Lose(building.Price);
            building.AssignOwner(moneyAccount);
            new CurrentMap().Get()
                .Enter(building, selectedTile.GetCurrentSelectedTileLocation());
            buySoundEffect.Play();
        }

        private bool IsBuildingSelected()
        {
            return buildingSelection.GetSelectedBuilding() != null;
        }

        public void Draw()
        {
        }
    }
}
