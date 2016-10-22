using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Pencil.Gaming;
using Pencil.Gaming.Graphics;

namespace Game_Project
{
    class main
    {
        static void Main(string[] args)
        {
            GameEngine engine = new GameEngine();
            Input input = new Input();
            engine.init(input);
            while (true)
            {
                engine.frame();
                if(input.left)
                {
                    Console.WriteLine("left");
                }
            }
        }
    }

    class GameEngine
    {
        GlfwWindowPtr gameWindow;

        public void init(Input input)
        {
            Glfw.Init();
            gameWindow = Glfw.CreateWindow(1000, 800, "Test", GlfwMonitorPtr.Null, GlfwWindowPtr.Null);
            Glfw.MakeContextCurrent(gameWindow);
            input.init(gameWindow);
        }

        public void frame()
        {
            GL.ClearColor(Color4.Aqua);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            Glfw.SwapBuffers(gameWindow);
            Glfw.PollEvents();
        }
    }
}
