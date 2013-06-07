Yna Engine
==========

#### Current version 0.6dev

### What is Yna Engine ?

Yna is a lightweight 2D and 3D game engine using MonoGame Framework (or XNA). The goal of this project is to give the developer the ability to create games in 2D or 3D easily on multiple platforms such as Windows Phone, Windows 8, or Linux. Yna is not a complex engine compared to its competitor and suitable for all developers who want an easy way to quickly create a prototype or a game.

### Plateforms

Yna Engine is currently support many plateforms
* Windows XP / Vista / 7 / 8 (Desktop)
* Windows 8 & RT (Modern UI)
* Linux
* Windows Phone 7
* Windows Phone 8

Do you want to see it working on another platform ? Fork it and send us a pull request.

### Sample 2D

```C#
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Yna.Engine;
using Yna.Engine.Graphics;
using Yna.Engine.Input;

namespace Yna.Samples.Screens
{
    public class AnimatedSprites : YnState2D
	{
        private YnSprite playerSprite;

        public AnimatedSprites(string name)
            : base(name)
        {
			// Background
            YnEntity background = new YnEntity("Scene/GreenGround");
            Add(background);

			// Player
            playerSprite = new YnSprite("Sprites/BRivera-malesoldier");
            spriteGroup.Add(playerSprite);
			
            // Objects
            YnEntity woodObject = new YnEntity("Scene/Tree");
            Add(woodObject);

            YnEntity wood2Object = new YnEntity("Scene/Tree2");
            Add(wood2Object);

            YnEntity houseObject = new YnEntity("Scene/House");
            Add(houseObject);
        }

        public override void Initialize()
        {
            base.Initialize();

            // The background size is the window size
            background.SetFullscreen();

            // Here, sprites are already loaded 
            playerSprite.Position = new Vector2(350, 350);

            // Force the sprite to stay on the screen
            playerSprite.ForceInsideScreen = true;

			// Add animations
			playerSprite.PrepareAnimation(64, 64);
            playerSprite.AddAnimation("up", 0, 8, 25, false);
            playerSprite.AddAnimation("left", 9, 17, 25, false);
            playerSprite.AddAnimation("down", 18, 26, 25, false);
            playerSprite.AddAnimation("right", 27, 35, 25, false);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Move the player
            if (YnG.Keys.Up)
			{
                playerSprite.Y -= 2;
				playerSprite.Play("up");
			}
            else if (YnG.Keys.Down)
			{
                playerSprite.Y += 2;
				playerSprite.Play("down");
			}
			
            if (YnG.Keys.Left)
			{
                playerSprite.X -= 2;
				playerSprite.Play("left");
            }
			else if (YnG.Keys.Right)
            {
				playerSprite.X += 2;
				playerSprite.Play("right");
			}
            
			// Shake the screen
            if (YnG.Keys.JustPressed(Keys.S))
                Camera.Shake(15, 2500);
            
            UpdateAnimations(playerSprite);
        }
    }
}

```

### Contributors

Lead developer : Yannick Comte (@CYannick)
Contributor : Alex Frêne (aka @Drakulo)
Logo & graphics : Thomas Ruffier

### Licence

Microsft public license. Take a look on LICENSE file for more informations