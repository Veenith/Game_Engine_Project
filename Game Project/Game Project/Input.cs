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
        public bool left, right, up, down, quit;


        public void keyCallBack(GlfwWindowPtr window, Key key, int scancode, KeyAction action, KeyModifiers mods)
        {
            if (key == Key.A && action == KeyAction.Press)
            {
                left = true;
            }
            if (key == Key.A && action == KeyAction.Release)
            {
                left = false;
            }

        }

        public void init(GlfwWindowPtr window)
        {
           Glfw.SetKeyCallback(window, keyCallBack);
        }  
         

    }
}
