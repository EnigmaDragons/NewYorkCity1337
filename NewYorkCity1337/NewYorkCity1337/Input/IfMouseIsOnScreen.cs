using System;
using Math;
using Microsoft.Xna.Framework.Input;
using NewYorkCity1337.Engine;

namespace Input
{
    public static class IfMouseIsOnScreen
    {
        public static void Execute(Action<MouseState> mouseAction)
        {
            if (MouseIsOnScreen())
                mouseAction.Invoke(Mouse.GetState());
        }

        private static bool MouseIsOnScreen()
        {
            var mousePos = Mouse.GetState().Position;
            return new IsInRangeInclusive(mousePos.X, 0, new GameInstance().Graphics.Viewport.Width).Evaluate()
                   && new IsInRangeInclusive(mousePos.Y, 0, new GameInstance().Graphics.Viewport.Height).Evaluate();
        }
    }
}
