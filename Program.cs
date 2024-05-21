using Aiv.Fast2D;
using OpenTK;
using OpenTK.Graphics.ES11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BOIDS
{
    internal class Program
    {
        public static Texture Texture { get; private set; }
        public static float HalfWith { get { return Texture.Width * 0.5f; } }
        public static float HalfHeight { get { return Texture.Height * 0.5f; } }
        public static Window Window { get; private set; }
        public static float DeltaTime { get { return Window.DeltaTime; } }

        

        public Vector2 mousePosition;
        static void Main(string[] args)
        {
            Window = new Window(1600, 800 ,"Boids");

            

            Texture = new Texture("Assets/boid.png");

            //Boid newBoid = new Boid();

            Boid b;//= new Boid(Window.MousePosition, new Vector2(1, 0));

             

            while (Window.IsOpened)
            {


                
                if (Window.MouseLeft)
                {

                    //Boid newBoid.SpawnBoid(Window.MousePosition, new Vector2(1, 0));
                    b.Position = Window.MousePosition;
                }


                //b.SpawnBoid();
                //b.Init();
                //b = OnMouseLeftClick();
                b.SpawnBoid(Window.MousePosition, new Vector2(1, 0));
                b.Update();
                b.Draw();
                b.WrapAround(b);
                

                Window.Update();
            }
        }

        public void OnMouseLeftClick()
        {
           // Boid.SpawnBoid(mousePosition);
            //if (Window.MouseLeft)
            //{
            //    Boid newBoid = new Boid(Window.MousePosition);
            //    Boids.Add(newBoid);  
            //}
        }

    }
}
