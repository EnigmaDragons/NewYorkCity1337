using System.Collections.Generic;
using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using NewYorkCity1337.Buildings;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Graphics;

namespace NewYorkCity1337.UI
{
    public class BuildingSelectionOverlay : IGameObject
    {
        private readonly List<Building> _buildings;
        private readonly Vector2 _screenPosition;

        private Texture2D _panelShadow;
        private Texture2D _panelBorder;
        private Texture2D _panel;
        private Texture2D _highlight;
        private int _selectedIndex = -1;

        public BuildingSelectionOverlay()
            : this(new Vector2(10, 10)) { }

        public BuildingSelectionOverlay(Vector2 screenPosition)
        {
            _screenPosition = screenPosition;
            _buildings = new List<Building> { new Beacon(), new Observatory(), new Antenna(), new Factory()};
        }

        public void LoadContent()
        {
            _panelShadow = new RectangleTexture(37, _buildings.Count * 50 + 5, Color.FromNonPremultiplied(0, 0, 0, 80)).Create();
            _panelBorder = new RectangleTexture(36, _buildings.Count * 50 + 4, Color.Black).Create();
            _panel = new RectangleTexture(32, _buildings.Count * 50, Color.Gray).Create();
            _highlight = new RectangleTexture(32, 50, Color.FromNonPremultiplied(255, 0, 0, 80)).Create();
            _buildings.ForEach(x => x.LoadContent());
        }

        public void UnloadContent()
        {
            _buildings.ForEach(x => x.UnloadContent());
        }

        public void Update(GameTime deltaTime)
        {
            var mouseState = Mouse.GetState();
            OnMouseOver(mouseState.Position);

            if (mouseState.LeftButton == ButtonState.Pressed)
                OnMouseLeftClick(mouseState.Position);
        }

        public void Draw()
        {
            new DrawOnScreen(_panelShadow, _screenPosition).Go();
            new DrawOnScreen(_panelBorder, _screenPosition - new Vector2(2, 2)).Go();
            new DrawOnScreen(_panel, _screenPosition).Go();
            if (_selectedIndex > -1)
                new DrawOnScreen(_highlight, _screenPosition + new Vector2(0, _selectedIndex * 50)).Go();
            for (var i = 0; i < _buildings.Count; i++)
            {
                new DrawOnScreen(_buildings[i].DisplayImage,
                    new Vector2(_screenPosition.X, _screenPosition.Y + i * 50)).Go();
                new DrawTextOnScreen(_buildings[i].Price.ToString(), new Vector2(_screenPosition.X + 14 - _buildings[i].Price.ToString().Length * 4, _screenPosition.Y + i * 50 + 32)).Go();
            }
        }

        private void OnMouseOver(Point mousePos)
        {
        }

        private void OnMouseLeftClick(Point mousePos)
        {
            var buildingNum = GetBuilding(mousePos);
            if (buildingNum != -1)
                _selectedIndex = buildingNum;
        }

        private int GetBuilding(Point mousePos)
        {
            var screenPoint = _screenPosition.ToPoint();
            if (IsInRange(mousePos.X, screenPoint.X, screenPoint.X + 50))
            {
                var buildingNumber = (mousePos.Y - screenPoint.Y) / 50;
                if (IsInRange(buildingNumber, 0, _buildings.Count - 1))
                    return buildingNumber;
            }
            return -1;
        }

        private bool IsInRange(int val, int min, int max)
        {
            return val >= min && val <= max;
        }

        public Building GetSelectedBuilding()
        {
            return _selectedIndex == -1 ? null : _buildings[_selectedIndex];
        }
    }
}
