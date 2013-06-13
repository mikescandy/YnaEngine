using Microsoft.Xna.Framework;

namespace Yna.Engine
{
    /// <summary>
    /// Define a safe updateable list for YnBase objects
    /// </summary>
    public class YnBasicCollection : YnCollection<YnBasicEntity>
    {
        /// <summary>
        /// Create method called after constructor.
        /// </summary>
        public virtual void Create()
        {
            for (int i = 0, l = _members.Count; i < l; i++)
                _members[i].Create();
        }

        protected override void DoUpdate(GameTime gameTime)
        {
            for (int i = 0; i < SafeMembersCount; i++)
            {
                if (_safeMembers[i].Enabled)
                    _safeMembers[i].Update(gameTime);
            }
        }
    }
}
