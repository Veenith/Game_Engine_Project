using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pencil.Gaming;
using Pencil.Gaming.Graphics;

namespace Game_Project
{
    class Input
    {
        string[] names = new string[10];
        bool[] held = new bool[10];
        Key[] controlKey = new Key[10];
        int numInputs = 0;
        
        public void init(GlfwWindowPtr window)
        {
            Glfw.SetKeyCallback(window, keyCallback);
        }

        public void keyCallback(GlfwWindowPtr window, Key key, int scancode, KeyAction action, KeyModifiers mods)
        {
            for (int i = 0; i < numInputs; i++)
            {
                if(key == controlKey[i] && action == KeyAction.Press)
                {
                    held[i] = true;
                }
                else
                {
                    held[i] = false; 
                }
            }
        }

        public void setupInput(string name, Key newKey)
        {
            names[numInputs] = name;
            controlKey[numInputs] = newKey;
            numInputs++;
        }

        public bool hold(string name)
        {
            for (int i = 0; i < numInputs; i++)
            {
                if (names[i] == name)
                {
                    return held[i];
                }
            }
            return false;
        }
    }
}
