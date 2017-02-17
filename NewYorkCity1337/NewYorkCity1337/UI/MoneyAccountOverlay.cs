using Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NewYorkCity1337.Business;
using NewYorkCity1337.Engine;
using NewYorkCity1337.Graphics;

namespace NewYorkCity1337.UI
{
    public class MoneyAccountOverlay : IGameObject
    {
        private readonly MoneyAccount _moneyAccount;
        private readonly Vector2 _screenPosition;

        private Texture2D _panelShadow;
        private Texture2D _panelBorder;
        private Texture2D _panel;

        public MoneyAccountOverlay(MoneyAccount moneyAccount, Vector2 screenPosition)
        {
            _moneyAccount = moneyAccount;
            _screenPosition = screenPosition;
        }

        public void LoadContent()
        {
            _panelShadow = new RectangleTexture(184, 34, Color.FromNonPremultiplied(0, 0, 0, 80)).Create();
            _panelBorder = new RectangleTexture(184, 34, Color.Black).Create();
            _panel = new RectangleTexture(180, 30, Color.Gray).Create();
        }

        public void UnloadContent()
        {
            _panelShadow.Dispose();
            _panelBorder.Dispose();
            _panel.Dispose();
        }

        public void Update(GameTime deltaTime)
        {
        }

        public void Draw()
        {
            new DrawOnScreen(_panelShadow, _screenPosition).Go();
            new DrawOnScreen(_panelBorder, _screenPosition - new Vector2(2, 2)).Go();
            new DrawOnScreen(_panel, _screenPosition).Go();
            new DrawTextOnScreen("Money: " + _moneyAccount.AmountAndCurrency, _screenPosition + new Vector2(2, 1)).Go();
        }
    }
}
