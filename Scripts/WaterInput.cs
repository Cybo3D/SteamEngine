using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SteamEngine.Input
{
    public class WaterInput
    {
        private Dictionary<string, List<object>> inputBindings;
        private KeyboardState previousKeyboardState;
        private KeyboardState currentKeyboardState;
        private GamePadState previousGamePadState;
        private GamePadState currentGamePadState;
        private bool useControllerInput; // Flag to determine which input source to use
        public WaterInput()
        {
            inputBindings = new Dictionary<string, List<object>>();
            currentKeyboardState = Keyboard.GetState();
            previousKeyboardState = currentKeyboardState;
            currentGamePadState = GamePad.GetState(PlayerIndex.One);
            previousGamePadState = currentGamePadState;
            useControllerInput = true; // Start with controller input enabled

            // Bind multiple input sources to the same action
            inputBindings.Add("Exit", new List<object> { Keys.Escape, Buttons.Back });
            // Add more as needed
        }
        public bool ButtonDown(string actionName)
        {
            if (inputBindings.ContainsKey(actionName))
            {
                var inputs = inputBindings[actionName];
                foreach (var input in inputs)
                {
                    if (useControllerInput && input is Buttons)
                    {
                        if (currentGamePadState.IsButtonDown((Buttons)input))
                            return true;
                    }
                    else if (!useControllerInput && input is Keys)
                    {
                        if (currentKeyboardState.IsKeyDown((Keys)input))
                            return true;
                    }
                }
            }
            return false; // Action not found
        }
        public bool ButtonUp(string actionName)
        {
            if (inputBindings.ContainsKey(actionName))
            {
                var inputs = inputBindings[actionName];
                foreach (var input in inputs)
                {
                    if (useControllerInput && input is Buttons)
                    {
                        if (currentGamePadState.IsButtonUp((Buttons)input))
                            return true;
                    }
                    else if (!useControllerInput && input is Keys)
                    {
                        if (currentKeyboardState.IsKeyUp((Keys)input))
                            return true;
                    }
                }
            }
            return false; // Action not found
        }
        public bool ButtonPressed(string actionName)
        {
            if (inputBindings.ContainsKey(actionName))
            {
                var inputs = inputBindings[actionName];
                foreach (var input in inputs)
                {
                    if (useControllerInput && input is Buttons)
                    {
                        if (currentGamePadState.IsButtonDown((Buttons)input) && !previousGamePadState.IsButtonDown((Buttons)input))
                            return true;
                    }
                    else if (!useControllerInput && input is Keys)
                    {
                        if (currentKeyboardState.IsKeyDown((Keys)input) && !previousKeyboardState.IsKeyDown((Keys)input))
                            return true;
                    }
                }
            }
            return false; // Action not found
        }
        public bool ButtonReleased(string actionName)
        {
            if (inputBindings.ContainsKey(actionName))
            {
                var inputs = inputBindings[actionName];
                foreach (var input in inputs)
                {
                    if (useControllerInput && input is Buttons)
                    {
                        if (currentGamePadState.IsButtonUp((Buttons)input) && !previousGamePadState.IsButtonUp((Buttons)input))
                            return true;
                    }
                    else if (!useControllerInput && input is Keys)
                    {
                        if (currentKeyboardState.IsKeyUp((Keys)input) && !previousKeyboardState.IsKeyUp((Keys)input))
                            return true;
                    }
                }
            }
            return false; // Action not found
        }
        public void SetInputDevice()
        {
            // Automatically switch between keyboard and controller input based on the input device in use
            if (currentGamePadState.IsConnected && currentGamePadState.Buttons != previousGamePadState.Buttons)
            {
                useControllerInput = true;
            }
            if (currentKeyboardState.GetPressedKeys().Length > 0)
            {
                useControllerInput = false;
            }
        }
        public void Update()
        {
            previousKeyboardState = currentKeyboardState;
            currentKeyboardState = Keyboard.GetState();
            previousGamePadState = currentGamePadState;
            currentGamePadState = GamePad.GetState(PlayerIndex.One);

            SetInputDevice();
        }
    }
}
