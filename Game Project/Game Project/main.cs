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
            input.setupInput("left", Key.A);
            input.setupInput("quit", Key.Escape);
            while (!engine.shouldClose())
            {
                engine.frame();
                if (input.hold ("left"))
                {
                    Console.WriteLine("left");
                }
                if(input.hold("quit"))
                {
                    engine.close();
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
            Glfw.SetWindowShouldClose(gameWindow, false);
        }

        public void frame()
        {
            GL.ClearColor(Color4.Aqua);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            Glfw.SwapBuffers(gameWindow);
            Glfw.PollEvents();
        }

        public bool shouldClose()
        {
            return Glfw.WindowShouldClose(gameWindow);
        }

        public void close()
        {
            Glfw.SetWindowShouldClose(gameWindow, true);
        }
    }
}
