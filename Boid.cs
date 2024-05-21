using Aiv.Fast2D;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BOIDS
{
    internal class Boid
    {
        public Vector2 Position { get { return sprite.position; } set { sprite.position = value; } }

        public Vector2 Velocity;

        public float speed = 200f;

        Sprite sprite;

        public static List<Boid> Boids;

        public static int BoidAmount;

        public static Boid []Vboids;            
        public Boid(Vector2 position, Vector2 velocity)
        {
            sprite = new Sprite(Program.Texture.Width, Program.Texture.Height);

            sprite.pivot = new Vector2(Program.HalfWith,Program.HalfHeight);

            Boids = new List<Boid>();

            Position = position;
            Velocity = velocity;
        }

        public void Update ()
        {
            Position += (Velocity * speed * Program.DeltaTime);
        }

        public void Draw()
        {
            sprite.DrawTexture(Program.Texture);
        }

        public void WrapAround(Boid boid)
        {
            if (boid.Position.X < 0)
                boid.sprite.position.X += Program.Window.Width;
            if (boid.Position.X > Program.Window.Width)
                boid.sprite.position.X -= Program.Window.Width;
            if (boid.Position.Y < 0)
                boid.sprite.position.Y += Program.Window.Height;
            if (boid.Position.Y > Program.Window.Height)
                boid.sprite.position.Y -= Program.Window.Height;
        }

        public EventHandler ClickEvent;
        public void OnClick()
        {
            ClickEvent.Invoke(this, EventArgs.Empty);
        }
        public void SpawnBoid(Vector2 position, Vector2 velocity)
        {
            Boid newBoid = new Boid(position, velocity);
            Boids.Add(newBoid);
        }

        public void Init() //generates X balls, out of which 1 red 
        {
            //spawn balls int totBoid
            //BoidAmount = totBoid;
            //Vboids = new Boid[BoidAmount];
            //for (int i = 0; i < Vboids.Length; i++)
            //{
            
            //if (Program.Window.MouseLeft)
            //    {
            //        Console.WriteLine("mouse clik");
            //        Boid boid = new Boid(new Vector2(Program.Window.Width * 0.5f, Program.Window.Height * 0.5f), new Vector2(1,0));
            //        sprite = new Sprite(Program.HalfWith, Program.HalfHeight);
            //        Boids.Add(boid);
            //    }
                
            //}
        }


    }
}
