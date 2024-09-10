﻿namespace ExampleOpenGL3
{
    using ExampleFramework;

    public unsafe class Program
    {
        private static void Main(string[] args)
        {
            App.Init(Backend.OpenGL);
            App.Run(new OpenGLWindow());
        }
    }
}