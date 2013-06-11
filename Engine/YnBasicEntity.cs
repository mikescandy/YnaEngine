using System;
using Microsoft.Xna.Framework;

namespace Yna.Engine
{
    /// <summary>
    /// Base class for all object on the Framework. A basic object is updateable
    /// </summary>
    public abstract class YnBasicEntity
    {
        #region private declarations

        private static uint counterId = 0x0001;

        protected uint _id;
        protected string _name;
        protected bool _enabled;
        protected bool _created;

        #endregion

        #region Properties

        /// <summary>
        /// Get the unique identification code of this object
        /// </summary>
        public uint Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Get or Set the name of this object
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Active or Desactive this object
        /// </summary>
        public bool Active
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        /// <summary>
        /// Pause or resume updates
        /// </summary>
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        /// <summary>
        /// Object has been created or not.
        /// </summary>
        public bool Created
        {
            get { return _created; }
            protected set { _created = value; }
        }

        #endregion

        public YnBasicEntity()
        {
            _id = counterId++;
            _name = String.Format("YnBase_{0}", Id.ToString());
            _enabled = true;
            _created = false;
        }

        /// <summary>
        /// Create instances of the object after construction.
        /// </summary>
        public virtual void Create()
        {
            _created = true;
        }

        /// <summary>
        /// Update method called on each engine update
        /// </summary>
        /// <param name="gameTime"></param>
        public abstract void Update(GameTime gameTime);
    }
}
