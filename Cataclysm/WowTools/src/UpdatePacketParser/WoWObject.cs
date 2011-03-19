using System.Collections.Generic;
using WowTools.Core;

namespace WoWObjects
{
    /// <summary>
    /// WoW Object Class
    /// </summary>
    public class WoWObject : WoWObjectUpdate
    {
        private readonly List<WoWObjectUpdate> updates = new List<WoWObjectUpdate>();

        public WoWObject(ObjectTypes typeId, MovementInfo movement, IDictionary<int, uint> data)
            : base(data)
        {
            TypeId = typeId;
            Movement = movement;
        }

        public ObjectTypes TypeId { get; private set; }

        public IEnumerable<WoWObjectUpdate> Updates
        {
            get { return updates; }
        }

        public MovementInfo Movement { get; private set; }

        public void AddUpdate(WoWObjectUpdate update)
        {
            updates.Add(update);
        }

        public uint GetGUIDHigh()
        {
            return GetUInt32Value(1); // OBJECT_FIELD_GUID (high)
        }

        public new ObjectTypeMask GetType()
        {
            return (ObjectTypeMask)GetUInt32Value(2); // OBJECT_FIELD_TYPE
        }

        private uint GetUInt32Value(int index)
        {
            uint result;
            Data.TryGetValue(index, out result);
            return result;
        }
    }
}
