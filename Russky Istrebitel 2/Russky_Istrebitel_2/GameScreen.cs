using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Russky_Istrebitel_2
{
    public class GameScreen
    {
        protected ContentManager Content;
        [XmlIgnore]
        public Type Type;

        public GameScreen()
        {
            Type = this.GetType();
        }

        public virtual void LoadContent()
        {
            this.Content = new ContentManager(
                ScreenManager.Instance.Content.ServiceProvider, "Content");
        }
        public virtual void UnloadContent()
        {
            Content.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {

        }
        public virtual void Draw(SpriteBatch spritebatch)
        {

        }
    }
}